# Prog4 hetedik előadás

> Disclaimer: az anyag kiegészítésül szolgál az előadás hivatalos anyagához. Ami nem szerepelt a dián, de elhangzott, és esetleg a vizsgán is hasznos lehet, az itt olvasható.

### Creational Design Patterns folytatása

#### Singleton pattern

- szürke zónában van, kevésse elfogadott, de sok helyen használják, mert könnyű használni
- "statikus" kreálás, hozzáférési lehetőség --> konstruktort lerejtjük
- egy statikus tulajdonságban érjük el az egy példányt
- sokkal több funkcionalitást biztosít, mivel 
- nem DI kompatibilis, nem tesztelhető a statikus tag
- sokak szerint ma már antipattern
- IoC containerrel flexibilissé tehető, evvel használható
- thread-safety elvárás, hiszen létrejöhetne több példány több szál esetén
- kölcsönös kizárás csupán durván szemcsézett megoldás
    - mivel lockolva vannak akkor is a szálak, amikor már van példány
    - "double check lock" 
        - ebben az esetben több példány már nem jön létre
        - probléma, hogy a fordítót meg kell vizsgálni (ismeri-e a double check lockot)
        - a hiba a fordító optimalizálásából ered, utasításokat képes az optimizer átrendezni
        - pl.: konstruálás esetén, `instance = new MyClass()` az utasítások sorrendje
<center>

|elvárt sorrend   |lehetséges valós sorrend   |
|---|---|
|memóriafoglalás   |memóriafoglalás   |
|példány létrehozása a címen   | memóriacím beírása a változóba   |
|memóriacím beírása a változóba   | példány létrehozása a címen   |

Ekkor lehetséges, hogy az egyik szál visszaad egy olyan példányt, mely még nem készült el, csak a címe létezik. Ennek megoldása lehet, hogy `volatile` kulcsszóval jelöljük meg, de .NET2 óta ez sem szükséges.
</center>

#### Builder pattern

Példányok létrehozásáért felelős, csakúgy, mint a factory pattern. A különbség, hogy itt **konkrét osztályokból** való példányosítást szeretnénk.

- egy builder = egy osztály
- jellemző felhasználás, amikor sok konstruktor paraméter van
- automatikus végrehajtásos megoldás a **BuilderDirector** (lásd Laby játék renderere, meghívogatja a Drawing metódusokat és feltölti a drawingContexet)
- jellemzőbb a manuális használata
- **fluent syntax** jól átláthatóvá teszi

#### Prototype pattern

Meglévő példányok másolásáért felelős pattern.

- deep copy = új példány saját memóriaterülettel, az eredeti adataival
- shallow copy = új példány a régi memóriaterületére mutat
- "deep", mivel pl. ha a példányban van egy tömb, abban referencia típusok, akkor ezeknek mind új memóriaterület kell
- **mindig** deep copy-t csinál a prototype pattern
- JavaScript a népszerűségét ennek a mintának köszönheti
    - nincsenek osztálypéldányok
    - az első példány legyen = típusdefiníció
    - az ezt követő példányok ennek az elsőnek a prototype-jai
    - ezzel kvázi meg van oldva a példányosítás problémája
- megvalósítás: 

```cs
public override ColorPrototype Clone()
{
    // adattagok copy konstruktoros újrapéldányosítása
    // pl. ha lenne egy "favColors" tömb, azt is itt újra létrehoznánk
    return new Color(red, green, blue);
}
```
- .Net-ben viszonylag népszerű, sok helyen használt (ICloneable interfész is van)
- MemberwiseClone() shallow copy-t csinál, de ha az objektumunkban eleve csak egyszerű típusok vannak, akkor ez megegyezik a deep copyval
- MemberwiseClone-ozás után a referencia típusokat kézzel újrapéldányosítjuk, duplikáljuk
- automatizálás reflexióval, vagy szerializációval lehetséges, sokkal kényelmesebb, de lényegesen rosszabb futásidőt produkál

### Behavioral Design Patterns

#### Iterator pattern

- szinte minden programnyelv implementálta már
- lényeg, hogy külső lerejtést végezzünk, minden kollekciót ugyanolyan külső szintaxissal kényelmesen be tudjunk járni
- saját típusnál testreszabható, miként akarjuk bejárni azt
- yield return mechanika: 
    - ciklus az elemeket bejárni
    - visszaadom az aktuális elemet
    - folytatom a ciklust
    - a belső működés ugyanaz kb, a motorháztető alatt komoly munka folyik

#### Chain of Responsibility pattern

- `foreach` ciklus használata esetén, vagyis iterator használatánál adatfeldolgozás a cél
- CoR esetén a feldolgozás a lényeg, jellemzően minden elemen szeretnénk valamilyen műveletet végezni
- a háttérben a láncolt lista létéről nem tudunk
- nagy switchek lecserélésére tökéletes
- **abstract factory** kiválasztásánál is jól használható
- variációk
    - feltétel nélküli pl. a logger chain: több helyen naplózás, kívülről csak `log()` látszódik
    - feltételes pl. az abstract factory esetén egy kollekcióban vannak az alfactoryk, ezeken végigmegy, és mindenkitől megkérdezi, hogy tud-e adott példányt létrehozni, ha igen, akkor itt megállunk
    - a kettő kombinációja nem szerencsés

#### Visitor pattern

Egyszerre dolgozik gyűjteményekkel, és szétválasztja a hívót és hívottat.

- visitor = logic, művelet, amit végezni fogunk az elemeken
- acceptor = subject, elem, amin a műveletet végezzük
- a műveletvégzést **mindig** az acceptor dönti el --> ő hívja a visitor `Visit()` metódusát
- visitor *esetleg* tudhat az acceptorokról, fordítva nem
- öröklés helyett jellemzően interfészek
```cs
class Person : IVisitorAcceptor 
{
    // personal data

    public void Accept(Ivisitor visitor)
    {
        // Bunch of ifs to decide whether the actual visitor can process the data or not.
        //E.g. if the visitor wants to log to remote host with plain FTP, do we allow it?
        visitor.Visit(this);
    }
}
```
- gyűjteményekre jól általánosítható

#### Observer pattern

- gyakorlatilag az eseménykezelés klasszikus megoldása
- prog2-n megismert interfészes megoldás nem elterjedt már, obsolete
- delegáltas megoldás sokkal jobb --> classok szintjéről metódusok szintjére lehozzuk az eseménykezelést
- nem kell az (interfész típusú) osztályreferenciát ismerni, csak a metódus szignatúrát kell ismerni, feliratkozáshoz sem szükséges külön metúdus, hiszen a `+=` operátor tudja ezt
- .Net-ben memory leak állhat elő --> weak reference (GB által bármikor felszabadítható)
- a C# `IObserver` **nem** ez a pattern, ennél jóval több (Rx framework)

#### Command pattern

- invoker kérését becsomagoljuk egy commandba
- gyakorlatilag receiver megfelelő metódusát hívja meg az invoker, de ezt a referenciát közvetlenül nem ismeri
- cachelésre, load balancingre is kiváló
- relay command megoldja, hogy ne kelljen minden műveletre külön class, csak egy-egy `RelayCommand` példány

#### Mediator pattern

Jellemzően komponensek összehangolására, felügyeletére használatos.

- pl. üzenetküldés objektumok között, anélkül, hogy tudnának egymásról **referencia** szerint
- a megoldás, hogy csak **azonosítókat** adok át
- nagyon népszerű, ezért rengeted meglévő kód van
- nem csak osztályok szintjén működik, hanem magasabb architekturális szinteken is