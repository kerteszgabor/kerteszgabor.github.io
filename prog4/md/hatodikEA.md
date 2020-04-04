# Prog4 6. előadás

> Disclaimer: az anyag kiegészítésül szolgál az előadás hivatalos anyagához. Ami nem szerepelt a dián, de elhangzott, és esetleg a vizsgán is hasznos lehet, az itt olvasható.

## Tervezési mintákról általában

### Bevezetés

maintainability, reusability > runtime

### SOLID elvek

#### S = Single Responsibility

- minden osztály egy dologért felelős, de azt jól csinálja
- szolgáltatásoknál sokan betartják, de nagy rendszerek esetén nem
- "godlike" appok --> **mindenért IS** felelősek

#### C = Open / Closed 

- tipikus codesmell, amikor módosítani kell az őst a leszármazott miatt
- egy funkció hozzáadása csak 1 leszármazott módosítását von

#### L = Liskov helyettesíthetőség

- a fordító csak szintaktikát figyeli a polimorfizmusnál, a szemantikát nem
- tehát runtime errort sem szabad kapnunk, nem elég, hogy fordul a kód

#### I = Interface segregation

- "god interface" alakul ki
- tünet: implementálásnál sok üres metódus marad
- jellemzően ha kódban össze-vissza implementálgatjuk az interfészt az is smelly

#### D = Dependency Inversion

- lehet példányosítani dolgokat, de a konkrét függőségek kívülről érkezzenek
- jellemzően interfészen vagy absztrakt osztályon függünk,
- majd dependency injection vagy más módszer a konstruktorban állítja a konkrét implementációt
- betartása segíti, hogy loosely **coupled komponenseink** legyenek

### Példa egy egyszerű SOLID megvalósításra

Egy csillagot akarunk mozgatni a konzolon

```cs 
interface IComplex : IDisplayable, IMoveable {}
class Star : IComplex {}
class Mover { public Mover(IComplex subject) };
class ConsoleMover : Mover {}
``` 

### Öröklés és kompozíció

> "Favor object composition over class inheritance"  

Ez nem azt jelenti, hogy nincs öröklés, hanem, hogy törekedni kell arra, hogy inkább osztályok egymásba ágyazásával oldjuk meg a problémát. Bár így kicsit nehezebben érthető a kód, de futásidőben át lehet átstruktúrálni azt.

#### Alapelvek

- újrahasznosíthatóság nem merül ki abban, hogy a class-t létrehozom, hiszen ha függőségeket helyezek el benne, akkor olyan, mintha nem is lenne különszervezve a többi komponenstől
- mivel nem lehet tudni előre (akár évekre), hogy milyen igények merülnek majd fel, ezért számítani kell rá, hogy **minden megváltozik**
- szakmai nyelvezet használata jócskán lerövidíti a megbeszéléseket a szakemberek (pl SCRUM-standup esetén)

Egyes alapelvek **elavultak** lehetnek: például az *iterátor pattern* szinte minden modern nyelvbe bekerült már, jellemzően mint `foreach` ciklus.

### Miből áll egy tervezési minta?

1. Pattern neve
2. Körülmény, ahol használható
3. Megoldás, működés leírása (jellemzően **UML class diagram**)
4. Hozományok (pozitív és negatív)
5. Implementáció (jellemzően programkód)

A vizsgán elérhető lesz mind a class diagram, mind a C# kód a tervezési minták mellé, de el kell tudni magyarázni ezeket.

## Tervezési minták alkalmazása

Junior fejlesztőként nem jellemző, hogy egyből tervezési mintákat implementálunk, inkább **legacy kóddal** foglalkozunk, minden egyes módosítás ijesztő lehet, de lehet, hogy sikerül rájönni, hogy az egyes legacy implementációk helyett milyen tervezési minta lenne használható. Ekkor értékelődnek fel az alábbi tervezési minták.

### Kiegészítés, a színek a prezentációban

#### Creational patterns

- Zöld - factory patternek

#### Behavioral patterns

- Zöld - hívó és hívott szétválasztása
- Piros - gyűjteményekkel dolgozó patternek
- Kék - a virtuális metódusok értelmes használata
- Nincs szín - nem kategorizálható


#### Structural patterns

- Zöld - funkció bővítésére használadnó minták (fontosak)
- Kék - a dependency injection használata (a könyvben nem szerepel, mert nem létezett a szó)
- Nincs szín - nem kategorizálható

> Ezeken kívül szerepelnek a kódokban `Console.WriteLine()` metódusok. Ezek feladata valamilyen logic műveletet reprezentálni.

### Creational design patterns

#### Factory method

- a funkcionalitáshoz szükséges példány előállítása a hívás helyén határozódik meg
- pl a validáció esetén a `[Validate]` attribútummal megjelölt tulajdonságok validációs metodikája merőben eltérő lehet, ezért a konkrét implementáció kiszervezésre kerül egy másik osztályba, és ez felelős a validáció létrehozásáért
- így elértük azt, hogy a `public bool Validate(object instance)` metódus csak validáljon, de **ne tudjon róla, hogy hogyan történik az ellenőrzés**
- absztraktabban: a BL nem kell, hogy tudjon a függőségekről
- tehát nem tudja, hogy ki(milyen factory), mit, és hogyan hoz létre, de tud dolgozni a létrehozott elemekkel
- factory esetén öröklési lánc kell (egy fajta factory --> ebből hiearhcia)
- eredetileg csak az öröklés határozhatja meg, hogy milyen példány jön létre a factory által, de manapság népszerű az a megközelítés, hogy a factory-n belüli `public T CreateSomeT(object param)` metódus valójában a `param` függvényében határozza meg, hogy milyen `T` jöjjön létre

```cs
public Image CreateImage(string typeOfImage)
{
    switch (typeOfImage)
    {
        case "PNG": return new PngImage(); // természetesen PngImage : Image
        case "JPG": return new JpgImage(); // természetesen JpgImage : Image
    }

    return null;
}
```

- ennek előnye, hogy kevesebb osztály kell, de nincs fordítási támogatás, tehát ha olyan osztályt kérünk, mely nem létezik akkor arról nincs visszajelzés
- ebben pl. egy IDE autocomplete segíthet
- 50 darab `case`-t írni, majd ezekben  megkeresni az elrejtett típust bonyolult lehet
- reflexió segítségével sokkal flexibilisebbé tehető ez, viszont lassulást eredményezhet
- ha mindenképpen szükségünk van arra, hogy legyen compiler support itt, akkor
  - generikus metódus lehet megoldás, pl. `CreateImage<ImgType>`
  - típusparaméter, pl. `CreateImage(Type imgType)`
  - ezeknél sajnos pontosan tudnom kell hol vannak az osztályok, összes DLL referenciának meg kell lenni, stb
- statikus factoryk használata egyre kevésbé elterjedt
- a kettő kombinálása `enum` segítségével lehetséges lenne, de nagyon rossz megközelítés, hiszen Open/Closed violation, mert az enumot bővíteni kell új típus esetén

#### Abstract factory

- Több factorynk van, és ezeket szeretnénk együtt kezelni
- Valós felhasználásnál nagyon gyakori
- Gyakori hiba, hogy nem csak service függőség létrehozására használunk factory-t, hanem bekerülünk egy *factoryceptionbe*, és a factoryk egymást hozzák létre szépen sorban
- Chain of responsibility ide kapcsolódik, lsd: 7. előadás

Dependency inversion megvalósítható vele, de a factory limitációja, hogy előre be lett programozva, hogy miket és hogyan tud létrehozni, és  ha automatizálni szeretnénk, akkor **IoC containereket** érdemes használnunk

#### IoC container

Életciklusuk két részre bontható:

##### Konfigurációs fázis

- `Service locator`-nek beállítom, a saját IoC-met
- `Register` metódussal beállítom, hogy milyen **interfész** és **osztály** párokkal kell dolgozni
- automata felderítés is működik sok esetben, illetve fejlettebb konténereket lehet config fájlból is konfigolni

##### Felhasználási fázis

> Szintaktikát nem kell ismerni  

- különböző containerek más-más szintaktikával, de nagyon hasonlóan működnek
- a működés basically: "ha valaki kéri `IExample` interfészt, akkor a szabálynak megfelelően hozzárendelt **assembler** segítségével kapja meg"

#### Hidden IoC

A függőségek kezelése az osztályon belül történik, nem pedig a konstruktorban, paraméterként --> elrejtődnek a függőségek, és újrahasználhatatlan lesz a kód. A metódusokat **nem** nézzük át átmozgatásnál, hogy milyen függéseik vannak, hiszen elvárjuk, hogy ne legyenek a kódban elrejtve ezek. Ha a metódus, vagy a konstruktor paraméterei között szerepel egy interfész, akkor tudjuk, hogy erre szükség lesz az átmozgatás után is.  
Néhány fontosabb elv:

- Ügyeljünk rá, hogy ne csak néhány függőség jelenjen meg a paraméterek között, hanem **szigorúan az összes!**
- Ha azt érezzük, hogy túl sok dependency-t kéne felsorolnunk, az egy code smell lehet, hiszen ha betartod a *single responsibility* elvet, akkor miért lenne szükséged 92 szolgáltatásra a metódusodban?