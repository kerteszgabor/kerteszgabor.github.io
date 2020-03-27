# Ötödik előadás

> Disclaimer: az anyag kiegészítésül szolgál az előadás hivatalos anyagához. Ami nem szerepelt a dián, de elhangzott, és esetleg a vizsgán is hasznos lehet, az itt olvasható.

## UML 2.0

### Strukturális diagramok

#### Deployment diagram

- olyan elemek, melyek nem a rendszer részei, külső elemek
- "konténerek"
- nem a program modulokon van a hangsúly
- a rendszer mely részei mely külső komponensekkel fognak kommunikálni
- első lépcsőfok fejlesztés során
- pl. a webszervernek semmi köze a rendszeremhez, mégis nagy hatással van rá

#### Component diagram vs package diagram

- csoportosításra alkalmas diagramok
- basically u.a, de a package diagramben nem csak osztályokat lehetne csoportosítani
- package esetén: a termék mely része a termék mely másik részét használja, vagy tartalmazza
- component esetén: nem a tartalmazás a lényeg, hanem, hogy a komponensek mely interfészeken keresztül kommunikálnak &#8594; sokkal közelebb áll a kódhoz "interfészközpontú"
  - portok (tehát a komponens határokon lévő kis négyzetek) elhagyhatók nekünk
  - component diagram kell a féléves feladathoz
  - pl. rétegzési elvek sértése hamar látszódik

#### Class diagram & object diagram

- fejlesztés közeli diagram
- user story választásakor már meg kell lennie, tehát a junior amikor választ már kell lássa, hogy milyen osztályokat kell írjon
- VS generál valamit, de a kapcsolatokat az osztályok között nem jelennek meg
- object diagram nem lényeges
- fontos: a dependency-knek van-e valamilyen extra logikai tartalma, miért van?
  - asszociáció: a nyíl irányát az ige határozza meg
  - strong asszociáció, vagy aggregáció: fontos, hogy az élettartam különböző
  - kompozíció: a rész objektumok nem létezhetnek egymás nélkül, élettartam egyezik

### Non-UML diagrams

#### Entity-relationship diagram

- a lényeg, hogy az egyedek közötti kapcsolatnál megadjuk az "igét" is, ami összekapcsolja őket
- van UML verziója is, ez gyakorlatilag egy butított class diagram
- az adattagok nem lényegesek, mint ahoy a class diagramnál sem

#### Gantt diagram

- projekt-időzítő diagram
- mikor állok neki a munkafolyamatoknak, illetve mikor végzek velük
- megszorítások megadása jellemző az ütemezéshez
- hosszútávú gantt-diagram **nem lehet pontos** &#8594; frissíteni kell
- folyamatok frissítése is lehetséges fejlesztés közben

### A szoftvertervezés menete

1. Deployment diagram
   - a rendszer kontextusa, mivel működünk együtt
2. Behavioral diagramok
   - felhasználói élmény dokumentálása
   - use casek definiálása &#8594; hogyan történik ez a folyamat &#8594; milyen felületen érhetőek el ezek
   - pl.: vásárlás &#8594; milyen lépések kellenek ehhez? &#8594; konkrétan milyen felületen kattingat a felhasználó ehhez
3. Struktúrális diagramok
   - komponens diagram: modulokra, alrendszerekre felbontás
   - &#8594; jöhet a sequence diagram, milyen algoritmizálható lépések vannak
   - class diagram:
      * lista az osztályokból
      * azok kapcsolata (aggregation, association stb..)
      * funkciók listázása
      * ekkor elkezd látszódni, mik a közös funkciók &#8594; öröklés
      * pull-up refactoring: ősosztály létrehozása, majd műveletek felmozgatása
4. Implementációs diagramok

### Féléves feladat

#### Model

- GameModel != ViewModel, mert nincsenek események, és commandok &#8594; csak adatok, a játék **egy állapotához** tartozók
- komolyabb esetben érdemes hiearchiát kialakítani a GameModelben &#8594; ne egy nagy adathalmaz legyen
- öröklés helyett kompozíciót érdemes használni &#8594; jövő hét, tervezési minták eleje (ECS tervezési minta)
- entity: játékelemek, komponensek: működések &#8594; E-C tábla
- kompozíció esetén futásidőben módosíthatóság

#### Logic

- a logic szempontjából az mindegy, hogy a metódust manuálisan, vagy automatikusan hívjuk meg

#### Renderer

- model megjelenítése
- WPF esetén nagy teljesítményt ne várjunk, cserébe egyszerű

#### Repositroy

- model lementése a cél (a játék egy állapota gyakorlatilag a HS)
- XML megközelítés erősen ajánlott

#### Tests

- Repobol és rendererből **mockolt** függőség lehet csak

#### Fejlesztési feladatok

- Master + Develop branch az elvárás
- sok conflict elkerülése végett érdemes feature-brancheket csinálni