# Prog4 6. előadás
> Disclaimer: az anyag kiegészítésül szolgál az előadás hivatalos anyagához. Ami nem szerepelt a dián, de elhangzott, és esetleg a vizsgán is hasznos lehet, az itt olvasható.

## Tervezési minták

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
class Mover{ public Mover(IComplex subject) }
class ConsoleMover : Mover {}
``` 