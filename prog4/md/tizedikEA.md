# Prog4 tizedik előadás

> Disclaimer: az anyag kiegészítésül szolgál az előadás hivatalos anyagához. Ami nem szerepelt a dián, de elhangzott, és esetleg a vizsgán is hasznos lehet, az itt olvasható.

### Structural Design Patterns 

    Emlékeztető: Structural patterns dia színek
    - Zöld - funkció bővítésére használadnó minták (fontosak)
    - Kék - a dependency injection használata (a könyvben nem szerepel, mert nem létezett a szó)
    - Nincs szín - nem kategorizálható

#### Adapter pattern

Object adapter néven ismert, feladata, hogy egy már működő funkcionalitást szeretnénk egy új implementációban is használni, anélkül, hogy az eredeti osztályt módosítanom kéne. Visszafele kompatibilitás megoldása esetén is gyakran előkerül.  
A szignatúra különbségek problémákat okozhatnak:
 - pl.: futásidőben ha paramétert kell átadni az új implementációban, akkor az a paraméter ki van már egyáltalán töltve, mikor átadom? Bool esetén, ha csinálunk egy property-t, az működhet, de ha false, az mit is jelent? Logikailag false, vagy csak nem lett kitöltve? Továbbá, mivel az ős nem tartalmazza a tulajdonságot, így kívülről teljesen elérhetetlen lesz ez, hiszen az ős referenciáján keresztül dolgozunk vele. 
- megoldás lehet, ctor paraméterként bekérni ezt az adatot (IoC container ezt szépen kitölti)
- nullable bool is információt hordoz arról, hogy írtuk-e már az adatot
- illetve setelésnél egy flag átbillentése majd későbbi ellenőrzése is megoldja a problémát

Ezen kívül probléma lehet a visszatérési értékek divergálása is
- pl.: double <---> string konvertálás - nagyon problémás lehet
- void helyett extra adat: redundancia, nem tudunk vele mit kezdeni, felhasználni

További probléma a metódusok számában lévő különbség
- ha az új implementációnak van extra metódusa, az általában kevésbé gond, megintcsak redundancia, használni nem fogjuk tudni
- fordított esetben nagyobb gond lehet, hiszen nem létező metódusokat hívhatunk kívülről az ősön keresztül --> megoldás, hogy **nem csinálunk semmit**

A létrehozásnál még oké, hogy tudunk a megvalósításról, de a felhasználásnál már mindenképpen **rejtett** kell legyen a működés.  
Data-adapterek .Net-ben
- bármilyen DB formátumából `DataRow` és `DataTable` kell, hogy készüljön
- LINQ esetén az utasítás (kifejezésfa) különböző adatszerkezeteken értelmezhető
- EF: több fajta SQL modelt tud leképezni C# osztályokra, valamint SQL lekérdezést generálni

#### Bridge pattern

> "Mi van akkor, ha egy rossz hiearchiát hoztam létre, és utólag vettem észre?"

Elsőre felépítünk egy logikus(nak tűnő) felépítést, de kiderül, hogy nem teljesen single responsibility, tehát kettő vagy több tényezőtől is függ a hiearchia --> a sokadik osztály hozzáadása több osztályt igényel
- megoldás: azonosítjuk a két tényezőt, "szétvágjuk" a *god* hiearchiát a függőségek mentén --> pl.: pull-up refactoring
- bridge elnevezés: összeköti a két ősosztályt valamilyen hivatkozási formával (dependency injection)
- ha szétbontjuk az erősen kötött hiearchiát, akkor lehet olyan felépítést is kreálni, ami nem szerencsés (ergo az eredeti felépítés nem véletlen lehetett kötött)

#### Composite pattern

Egy teljesen egyszerű, hétköznapi faszerkezetet ír le, ahol ugyanaz a művelet lehetséges a teljes fára, illetve bármelyik részfára, vagy akár egy levélelemre. Ritkán használt, legalábbis ilyen explicit módon.

#### Flyweight pattern

Nagyon hasznos trükkökből áll össze a pattern, de egyben szinte soha nem használatos. Célja, hogy a memóriaigényt csökkentse a program esetén, olyan módon, hogy a többi programozó, illetve a felhasználó se vegye észre a trükköket. 

- memóriaoptimalizációs technika 
- pl.: threadpool esetén úgy tűnik, mintha végtelen sok szálunk lenne létrehozható, közben pedig recycling történik
- pl.: karakterek kiírása egy hosszú szöveg esetén: az ismétlődő karaktereket nem biztos, hogy el kell tárolni mindenhol
    - **rejtett** Singleton megoldás, *Type* típusok használat erre ideális, mivel a `instance.Gettype()` eleve Singleton módon, egy közös példányt ad vissza
    - **rejtett** shared pointer, string típus ideális erre
    - a fentiek miatt nem szerencsés lockolni ezeken az objektumokon C#-ban
    - pozíció kiszámolása *on-the-fly* módon: megintcsak CPU igényes, de nem kell eltárolni pozíciókat
    - Object pooling: példánykészletek állnak rendelkezésre, új elem létrehozása - ha nincs rendelkezésre álló példány - úgy történik, hogy valamilyen módon felszabadítunk a használatban lévő elemek közül egyet. Manapság annyira népszerű, hogy szinte kiemelődött önálló patterné.
    - .Net-ben a string osztály rendelkezik beépített poolal, és automatika folyamatosan figyeli a háttérben, hogy mikor egyeznek stringek, mikor lehet őket beemelni a stringcache-be, majd pointerrel rámutatni több helyről erre a cachelt elemre. Alapvetően pl.: műveletek eredményeit nem teszi bele
- pl.: lazy loading (Androidon) is ehhez kapcsolódik: 10 elem látható egy listában a képernyőn, scrollozás esetén, ami kicsúszik a képernyőből azt nem felszabadítjuk, hanem újra felhasználjuk

#### Facade pattern

Nem definiál logikát, az a feladata, hogy a belső rendszert, a felépítést, a függéseket elrejti a kint lévő használó klienseknek. Nagy veszélye, hogy könnyen *god-object*ek alakulhatnak ki

- a forráskódból sokszor nem látszik milyen patternről van szó, hiszen kívülről kompozíciónak tűnik minden ilyen pattern
- a facade pl.: sorrendet meghatározhat, de ezen túl **semmilyen** üzleti logikát sem
- CoR filozófiájához hasonló, hiszen a belső hívásfolyamat kívülről le van rejtve
- architektúrális tervezési minta: van valós életben is látható példa rá. pl.: package holiday

#### Proxy pattern

Gyakorlatilag egy másolat egy eredeti osztályról, ugyanazokkal a metódusokkal. A különbséget az jelenti, hogy elő-és utófeldolgozásra van lehetőség a metódusokkal. A truvájt az jelenti, hogy kívülről le van rejtve ez a proxy, és simán lehet, hogy úgy helyettesíti az osztályt, hogy valójában ezt nem is érzékeljük. Ennek köszönhető, hogy bonyolult frameworkok baromi egyszerűen használhatóak.

- pl.: EF esetén a tulajdonság módosítása **nem** csupán egy `set;` szetter állítás, hiszen a savechanges hívás honnan tudná, hogy milyen `UPDATE` SQL utasítást kell kiadni?

Fajtái:

- **remote proxy**: úgy tűnik, mintha local namespace eleme lenne, amit használunk, de valójában a tényleges osztály valahol egész máshol van (másik app, felhő, stb...)
- **virtual proxy**: entityk esetén nem biztos, hogy minden tulajdonság le van töltve, lehetséges, hogy a `get;` híváskor fut csak le az SQL lekérdezés, és kerül feltöltésre a tulajdonság
- **protection proxy**: autentikációt végez
- **smart reference**: proxyra egy alternatív elnevezés, egy olyan referencia, ami extra műveletekre is képes

A proxyban lehetnek extra metódusok, de **nem lehetnek** publikusak!

#### Decorator pattern

Ez is egy fontos minta, jellemzően nagyobb programok esetén használatos. Lényege, hogy ezúttal bővíteni tudunk funkcionalitáson publikus módon, és ezek a funkciók **egymásba helyezhetőek**.  
Univerzális bővítés, mert lehet facade, proxy, és hozzáadhat plusz funkciót is.
pl.: textbox esetén (dián példa, textview, scrollbar, keret bővítők) ezek így néznek ki
- facade, ha írok a textboxba: mást látok, mivel ki van dekorálva a textbox, de ez semmit nem befolyásol
- proxy, mert ha kattintok előfeldolgoz, hogy pl. hova nyomtam a textboxon
- plusz funkciót ad hozzá, mert scrollozható az ablak, illetve lehet extra tulajdonsága, pl. border color
- fontos, hogy a kompozíció miatt bármi bővíthető bármivel, és ez futásidőben befolyásolható, módosítható is
- hasonló az öröklődéshez a működés, csak előnye, hogy **futásidőben** cserélhetőek a viszonyok
- ennek hátránya, hogy nem lehet debuggolni gyakorlatilag, mivel átláthatatlan, hogy a hívásoknak mi az útvonala
- másik hátránya, hogy a láthatósági szinteken növelni kell, mivel OOP szabály, hogy a protected láthatósági szintnél másik, független osztály mezőjét nem érhetem el. Ez ugye akkor fordulna elő, ha a leszármazottban a referencia esetleg nem a saját, decorator típus, és nem is az ős típusa, hanem esetleg egy harmadik, független leszármazotté



 <h2> A korábban látott patternek összehasonlítása </h2>

|Pattern   	|Új művelet?   	|Egymásra helyezhető   	|Known?   	|
|:-:	|:-:	|:-:	|:-:	|
|**Facade**   	|nem (csak sorrend)   	|nem   	|igen   	|
|**Proxy**   	|igen (pre/post method)   	|ritkán   	|ritkán   	|
|**Decorator**   	|igen   	|igen   	|igen, de nem muszáj   	|
