# Negyedik előadás

> Disclaimer: az anyag kiegészítésül szolgál az előadás hivatalos anyagához. Ami nem szerepelt a dián, de elhangzott, és esetleg a vizsgán is hasznos lehet, az itt olvasható.

## UML 

### Mi az az UML?

- ez is egy nyelv, csak modellező
- "best of the worst"
- sharable knowlegde, egyértelmű, mert szigorú (ennek betartatása már cégfüggő)
- vannak saját megoldások, de azok nem univerzálisak
- bővíthető a specifikációja
- független a programozási nyelvtől, de az **OO központúság** az elvárás

### Mivel rajzolunk UML diagramokat?

- bármivel! csak szép legyen:)
- rengeteg eszköz van

### Viselkedési diagramok

#### Use case diagram

- mind számít: milyen típusú a vonal, milyen irányba mutat, honnan 
- aktorok és használati esetek
- jellemzően leírható lenne egy egyszerűbb táblázatos formában
- nagyon bonyolult rendszerek esetén van értelme igazán

#### Activity diagram 

- nem a háttérben futó működés a fontos, hanem a felhasználó szempontjából a rendszeren átfutó változások
- több use case leírása is lehetséges egy activityn belül 
- vízszintes vonalak: join és fork 
- "BL" szó megjelenése: a user számára csak információval szolgál arról, hogy van valami ilyesmi komponens, nem biztos, hogy a tényleges megvalósítás így néz ki a logicban

#### State diagram

- lekerekített diagram itt: állapot
- nyíl: állapotok közötti változás
- minden egyes nyílra rá kell írni, hogy mi a feltétele annak a változásnak
- alternatíva pl. a petri hálók: *fuzzy logic* modellezésére alkalmasabb, manapság nagyon népszerűek

#### Interaction diagram

- "melyik elem melyikkel kommunikál"
- mélyebb implementáció megjelenítése (osztályok közötti, de akár metódusok közötti) kommunikáció
- mindegyik átírható sequence diagramra, de ez visszafelé nem igaz
- leghasznosabb közülük a sequence diagram
    ##### Timing diagram
    - nagyon kis neat, de ha megnő, akkor átláthatatlan lesz
    ##### Sequence diagram
    - csak vízszintes vonalak! 
    - a *nyílhegy formájú* diagram általában jó 
    - bal felső sarokból indulva a nyilakat követve simán kiolvasható az egész algoritmus

### Wireframe

- minél előbb a user kezébe kerülhet
- "látványterv"
- gyors feedback, ez segítheti a tervezést már a korai fázisban
- nem a konkrét megjelenítés a lényeg, hanem az **elrendezés**
- nem érdemes elszállni a dizájnnal, ha a megvalósítás utána problémás 
- folyamatok végigjátszhatóak legyenek: egymásutániságot jelezni kell (nyilak, megjegyzések)