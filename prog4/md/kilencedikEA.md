# Prog4 kilencedik előadás

> Disclaimer: az anyag kiegészítésül szolgál az előadás hivatalos anyagához. Ami nem szerepelt a dián, de elhangzott, és esetleg a vizsgán is hasznos lehet, az itt olvasható.

### Behavioral Design Patterns folytatása

     Emlékeztető: Behavioral patterns

    - Zöld - hívó és hívott szétválasztása
    - Piros - gyűjteményekkel dolgozó patternek
    - Kék - a virtuális metódusok értelmes használata
    - Nincs szín - nem kategorizálható

#### Interpreter pattern

Kifejezéseket próbálunk értelmezni (pl. reguláris kifejezések), a **single responsibility** elvet követve a pattern azt mondja, hogy minden osztályunk tartalmazzon egy *Interpret* metódust, és mindegyik egy fajta kifejezést tudjon értelmezni.

- kifejezésfák jönnek létre
- van egy context, és minden osztály azért felelős, hogy azt a saját felelősségi köre alapján módosítsa
- van egy absztrakt ősosztály, ami meghatároz egy interpret metódust, ezt írja fölül minden alosztály
- több expression *chain of responsibility* módon módosítja az outputot, ezt persze kívülről le van rejtve
- terminal expression: értelmezhető önmagában
- non-terminal expression: nem értelmezhető önmagában, csak más kifejezésekkel együtt (pl.: X a római számoknál önmagában non-terminal, mert lehet IX valójában...)
- nagyon általános megoldás, így alig-alig használható
- állapotgéppel jellemzően egyszerűbb a feldolgozása ezeknek a kifejezéseknek
- marginális pattern
- viszont nagy előnye, hogy szinte **bármire** használható, bármiből bármit tudunk konvertálni
- flexibilis, bővíthető, ha minden kifejezés "egy élre játszik"
- tradeoff: nagy overhead, sokszor overkill, és nem hatékony rengeteg osztály egy egyszerű ciklus helyett

Példa: Roman --> arab számok. Minden egyes expression (jelen esetben helyiérték, tehát 1-es, 10-es, 100-as stb...) tárolja a hozzá tartozó számjegyeket, valamint a helyiérték koefficiensét (pl.: 10-esnél X: One, XC: Nine, és a szorzó 10). Minden helyiérték `interpret`-e feldolgozza a saját karaktereit, majd levágja azokat, és ekkor már hozzáadta a kiszorzott értéket a végeredményhez.

#### Memento pattern

Szintén erősen illeszkedik az **SO**-ba. Feladata az előző állapot mentése és visszaállítása.

- `Originator` osztályt használjuk két functionnel: `Undo()` és `Redo()`
- a megvalósítás teljesen mindegy kívülről, a `Memento` és a `Caretaker` lehetnek rejtett osztályok
- `Memento` feladata az egyszeri mentés és visszaállítás
    - láthatósági okokból előfordulhat, hogy nem csak a menteni kívánt objektumot adjuk át paraméterként, mivel a privát adattagokat is el kell érni
    - a másolat mindig **deep copy** --> *prototype pattern* tökéletesen kapcsolódik ide
    - ugly megoldás: szerializáció és deszerializáció
- `Caretaker` feladata több `Memento` példány tárolása
    - itt célszerű a belső szerkezetet (listát) lerejteni, és kivülről verziókezelés-szerűen elérhetővé tenni
    - eleve, nem jellemző felhasználás, hogy `ctrl-z` esetén tudjuk, hogy mire ugrunk vissza, csak visszalépünk egyet
    - undo után save: második visszavonás gyakorlatilag egy *redo*

#### State pattern

Abban különbözik a memento-tól, hogy amikor a mentésről beszélünk, akkor nem egy teljes objektumról van szó, hanem egyetlen **egy adattagról**, ami az objektumhoz, vagy adott esetben az objektumhoz kapcsolódik.

- state UML-diagram kapcsolódik hozzá
- állapotváltoztató kódrészletek egyszerűsítésére szolgál, megakadályozza, hogy spaghetti-kódot írjunk
- ez a rendszer szintén **SO**, mivel nincs godclass, hanem **minden státuszhoz** tartozik egy osztály
- ezek az állapotosztályok az **állapotváltoztatást** is elvégzik
- tehát ezek a váltások fix helyre kerülnek a kódban, nem pedig össze-vissza találhatóak
- factory minta ide kapcsolódik: állapotok létrehozása kiszervezhető egy gyárba
- prototype minta szintén: létrehozzuk a (véges számú), összes állapotot, majd ezeket "másoljuk" át minden alkalommal


Változatok:  

- az üzleti logika metódusokat "leképezzük" a state osztályba (bár nem végez logikát, csak **tud róla**, hogy milyen logika van), és - kevésbé *SOLID* módon - kezeljük az állapotváltozást
    - State Transition Table
        - könnyen átlátható (1 cella = 1 metódus)
        - de bővítés, sok state, sok művelet esetén rengeteg felesleges metódus
- semmi köze a logikának a változtatáshoz, csak módosítja a statet a metódus, ez talán kevésbé átlátható
    - UML diagramos változat
        - nem tud a state a logikáról
        - szomszédos állapotba lép csak az állapot mindig
        - `EnsureState()` metódus végzi ezt
        - azonban ez bonyolult lehet --> CoR-val megoldható, de akkor meg az osztályok száma nőne
        - feltételek óvatos megválasztása szükséges, ha nem diszjunktak, akkor könnyen "végtelen ciklusok" idézhetőek elő 
        - bár ez SOLID-abb, de nincs olyan, hogy a kecske is eszik, meg a káposzta is megmarad: itt az üzleti logikai műveletek végén hívódik meg a változtatás, tehát ismerni kell, hogy mikor kell állapotot változtatni

#### Strategy, Template method

S**OL**I**D** elvekhez erősen kapcsolódik. Mindennapi programokban, intenzíven használatosak. Jellemzően ősosztállyal történő dependency injectionre használható.

- Strategy: a műveletsort teljesen a leszármazottak definiálják
    - ez a library-hez kapcsolható: vannak ősosztályok, és ezeket használjuk fel
    - pl.: ASP.NET core Identity
    - elnevezéshez kapcsolódik: *"stratégia"* van megadva valamilyen műveletre, ami művelet független működik a konkrét implementációtól (pl.: DB esetén: SQL-NoSQL-mockolt repository - teljesen mindegy, az üzleti logika mindig működik)
- Template: ősben method, valamint virtuális metódusok, amik az algoritmust meghatározzák, és a leszármazottak ezeket írják felül
    - ha elég nagyban nézzük, gyakorlatilag ez a framework: kívülről működtet egy felhasználó program leszármazott kódokat 
    - pl.: a használt MVC fw lekezeli a request-responsokat, mi csak  legeneráljuk a válaszokat, és formulázzuk azokat, de végig csak szabályokat követünk, és a framework hívja meg a kódunkat valahol

