# Prog4 tizenegyedik előadás

> Disclaimer: az anyag kiegészítésül szolgál az előadás hivatalos anyagához. Ami nem szerepelt a dián, de elhangzott, és esetleg a vizsgán is hasznos lehet, az itt olvasható.

## Martin Flower: Patterns of Enterprise Application Architecture

### Rétegzés

A már megismert rétegzési módszertanok nagyon merev megközelítést adtak: mindig ugyanazokon a rétegeken keresztül mentek a requestek, független attól, hogy a programot éppen a felhasználó használja, API végpont éri el azt, vagy teszteljük.

#### Onion / hexagon architecture

Az alkalmazás magja adja a logikát, erre épülnek külső rétegek, amik különféle portokon keresztül kommunikálnak a külvilággal (data és command adapterek: a különböző port-specifikus reprezentációkat konvertálja a mag számára értelmezhető formára, majd vissza). Minden port saját rétegzéssel rendelkezhet.

Rétegfüggetlen komponensek, vagyis aspektusok használata is gyakori filozófia. Ezek ún. cross cutting concernek, ilyen például a messenger, naplózás, vagy az autentikáció. Jellemzőjük, hogy nem kötődnek egyértelműen réteghez, több réteg között is átjárást biztosíthatnak, de fontos, hogy nem tehetik tönkre a rétegzésünket.

#### Domain-Driven Design

A klasszikus rétegzés okozta merevséget, korlátokat hivatott feloldani, átlépni. Alapfilozófiája, hogy minden, beleértve a rétegzés is az **üzlettől** kell függjön, a BL körül kell központosulnia.

> "Nem az számít a rétegzés szempontjából, hogy hogyan érem el az adatot, hanem, hogy mit csinálok vele."

A cél, hogy "üzleti logikai" entitásokkal dolgozzunk, ne data entitásokkal --> bounded contextek.  
Példa: több helyen is használjuk ugyanazt az adatot a programban, ekkor **nem** egy darab osztályként kezeljük mindenhol (hiszen a különböző contextekben máshogyan van szükség erre az adatra), hanem létrehozunk a bounded contexteknek megfelelő osztályokat, és azokkal dolgozunk. Ezek persze egy **mapper** segítségével megfeleltethetőek a data entitásnak, pl. EF is tud ilyen mapolást csinálni.  
Vigyázat! Túl nagy vagy túl kicsi felelősségi körrel rendelkező contextek is előállhatnak. A kódújrafelhasználhatóság miatt fontos, hogy a modulok is eléggé függetlenek legyenek, hiszen átmozgatáskor fontos, hogy csak egy komponenst vigyünk át.  

Kiegészül a "hagyma" mégegy réteggel, ez pedig a **Service layer**. Ennek feladata, hogy a domain réteg elemei egymással tudjanak kommunikálni --> microservices. Mindegyik szolgáltatás egy saját "szeletként" fogható fel (saját data, saját domain level, mapper + logika, valamint szolgáltatás), és ezek kommunikálnak egymással --> nem egy monolitikus alkalmazás van, hanem egy **több nyelven íródott**, szegmentált app. A service layer gyakorlatilag egy facade, nem tartalmaz logikát.

Ebben az átalakult rétegzésben a UI egy ugyanolyan lebutított szolgáltatás, rendelkezik akár saját adattal is (pl.: UI beállításai)

Service layer, the real DDD way: is in perfect balance, like all things should be in the universe.
- adatok olvasásakor, megjelenítésekor több bounded contextet kell olvasni, hogy megkapjunk minden adatot, ez lassabb. Viszont ekkor nem kell foglalkozni validációval, naplózással, stb... --> csomó servicet nem használunk
- íráskor csak egy bounded contextet írunk, azonban sok szolgáltatást használunk ehhez

## CQRS (Command-Query Responsibility Segregation)

Ez összefoglalja az imént említetteket, tehát azt, hogy miképpen választható szét az írás olvasás folyamata.

### Query esetén

A cél, hogy **gyorsan**, egyszerűen érjük el és jelenítsük meg az adatokat.

- nincs szükség az összes rétegre az olvasáshoz: elég, ha a db-t kezelő réteg odaadja a UI-nak az adatokat
- nem számít, hogy a user milyen **régi adatokat** lát (az esetek nagy részében). Tehát csinálhatunk egy saját, független tárolót (ami mellesleg jól reprezentálja a megjelenítést, gyakorlatilag egy-az-egyben megjeleníthető), majd ezt bizonyos időközönként frissítem a real DB alapján. Gyakorlatilag ez egy új, *persistent viewmodel* adatbázis, ami ráadásul lehet noSQL, kifelé egy SELECT utasítás elég, nem kellenek bonyolult DB műveletek.
- real life usecase arra, hogy miért kell szétválasztani a query-t és a commandot: sokan olvassák az oldalt, kevesen írják --> hatalmas erőforrás megtakarítás
- probléma, hogy a dinamikus, egyedi keresések (pl.: egy szóra keresünk egyik oszlopban) nagyon lassúak, és erőforrás-igényesek, a relációs adatbázisok ebben nagyon gyengék
- ez megoldható úgy, hogyha azt tekintjük, hogy a keresések kb. 95% még sem "egyedi", hiszen a felhasználók ismétlik ezeket --> ezek is betölthetőek a viewmodelbe

### Command esetén

UI-ról érkező command alapján frissítjük a viewmodel DB-t, és az éles DB-t. Hibalehetőségek:

- ritkán előfordulhat, hogy a command failel --> de csak emiatt kár várakozni a megerősítésre, egyből válaszolunk, hogy igen, sikerült a command, majd végrehajtódik majd aszinkron módon. Persze megintcsak figyelni kell rá, hogy vannak esetek, ahol ez nem használható

#### Event-driven architecture

A CQRS-hez jól kapcsolódik, hiszen nem gond, ha az utasítások nem egyből hajtódnak végre. Ez a user experiencet is javítja, hiszen pl. foglalási rendszer esetén egyből kap visszajelzést, hogy sikeres a foglalás. Kb 3-4%-ban, ahol ezután hiba történik, ott kézzel meg lehet oldani a dolgokat.

- erőforrás-hatékony
- flexibilis: pl a diákon.: 
    - megvan egy olyan program, ami megadja, hogy hány bizonyos feltételnek megfelelő telefonszám van az adatbázisban
    - ez klasszikus rétegzés esetén szépen végigmegy a rétegek között
    - mi van akkor, ha most szeretném, hogy összesen hány telefonszámból számoltunk? Át kell írni az összes réteget ehhez
    - megoldás: eventekkel; a közvetítő most már nem csak arra iratkozik fel, hogy `MatchingNumbersCounted`, hanem arra is, hogy `AllNumbersCounted`. Ez utóbbit pedig a sima munkafolyamat megfelelő részén (összes szám lekérése) egy másik eseményhívással számoljuk meg.
- event sourcing: a command bekerül egy command sorba (ez tényleg csak egy queue), ezután ezt handlerek, illetve a domain model feldolgozza, majd egy eseményt vált ki, amit egy mediator-jellegű event-broker  szétpakol (DB-be menti, naplózza, viewmodelbe teszi)
- ez nagyon hatékony, a várósorról akárhova kerülhet a command, akár külső feldolgozásra is, így nagyon jól **skálázhatóvá** válik a rendszer
- könnyű a visszakeresés is
- extra információk is kinyerhetőek plusz adatok tárolása nélkül (mivel az eventek idejét látjuk, stb...)
- tesztelés is könnyebb

Hátrányok:

- olyan jelentések, amiket megszoktunk a RLDBMS esetén (Group by, stb...) sokkal nehezebb itt
- hibák nem egyből jönnek elő, delay van
- nagyobb tárigény
- ezek miatt nem mindenhol, észnélkül használható pattern a CQRS

Összefoglalás ezen a [videón](https://youtu.be/ryu11M-7zto?list=PLGgtxIMNuefboI3yZCdYAAly4zb3X5p-M&t=4113). 