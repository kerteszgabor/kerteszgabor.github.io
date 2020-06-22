# Prog4 tizenegyedik előadás

> Disclaimer: az anyag kiegészítésül szolgál az előadás hivatalos anyagához. Ami nem szerepelt a dián, de elhangzott, és esetleg a vizsgán is hasznos lehet, az itt olvasható.

## Microservices

### Monolitikus vs Mikroszervíz

A monolitikus alkalmazások erősen rétegzett, szigorú szabályok szerint írt alkalmazások. Alapja, hogy a rétegek egymástól függetlenítésére törekszünk, a funkciók megjelennek a különböző rétegekben.  
Ezzel szemben láttuk a DDD-nál, hogy a funkciók mentén szét lehet darabolni az alkalmazást **bounded contextekre**, azonban ezek még mindig egy alkalmazásban vannak. Ha ezeket kiszervezzük **külön alkalmazásokba**, majd loosely-coupled módon összekötjük őket (jellemzően web) 
Ez a vita mostanában éleződött ki, de a vita ősrégi (lásd.: Tannenbaum-Torvalds vita a linux kernelről), az tény, hogy a kevésbé kötött alkalmazás növeli a flexibilitást, de rontja a teljesítményt. Nem lehet kijelenteni, hogy egyik vagy másik jobb lenne, de kétségtelen, hogy a microservicek manapság egyre népszerűbbek.

#### Monolitikus alkalmazások

Egy forráskód, ami modulokra lehet bontva. A fejlesztés persze szétbontható, de a végén az összekapcsolt modulok együtt fognak működni, egy exeben, egy memóriaterületen. Ráadásul a modulok nem választhatóak szét teljesen, fejlesztési időben is van függés, hiszen integrálni kell majd őket (persze DI sokat segít, és külön-külön tesztelhetőek), és ez lassítja a folyamatot.

- ugyanazokat a komponenseket (pl.: JSON olvasás) kell használni a program összes pontján (nem tudunk "modularizálni")
- még mindig egy adatbázist használunk, persze a mapper megoldja ezt valamennyire, de a függőségeket nem lehet feloldani
- skálázhatóság: ha van egy modul, ami nagyobb erőforrást igényelne, akkor nem tudok neki többet osztani, csak egyben az egész program számára --> bottleneck
- fejlesztési folyamat nő, ahogy nő az alkalmazás (frissítés, új funkciók tesztelése nehézkes, lassul a program, érdemes elolvasni Bob bácsit a témában, bemutatja példákon keresztül, hogy nagyon jó appok hogyan mentek tönkre úgy, hogy "god" appok lettek)
- de előnyt jelent, ha egy helyen kezeljük az adatokat (kommunikáció *sokkal* könnyebb, hatékonyabb, mint weben átadni adatokat), és könnyebb is megírni így a programot (code-generation, IDE support)

#### Mikroszervíz alapú alkalmazások

Önálló, elszigetelt alkalmazások. Jellemző buzzword a SOA (= szolgáltatásorientált-architektúra), ez írja le az egész rendszert. Kis modulok, melyek előre definiált protokollokon keresztül kommunikálnak egymással.  
Önmagukban életképes, teljesen szuverén alkalmazások (saját fejlesztési metodológiával, hostolással, verziókövetéssel)

##### Előnyök

- skálázhatóság
- még jobban elválnak a servicek fejlesztési szempontból: egyáltalán nem függnek egymástól, így "jobban párhuzamosítható" a fejlesztés --> akár az egész fejlesztési időtartam csökkenhet
- bugok is jobban kezelhetőek, detektálhatóak (és eleve, mellékhatások csökkennek)
- vannak nagyméretű *micro*servicek is, tehát inkább filozófia ez
- felbontási határok: megintcsak nem technológiai határok, hanem **logikai**, üzleti szemlélet (lásd: bounded contexts)
- autonóm tesztelési szempontból is (service stub), nagyon hasonló a monolitikus appokhoz
- migráció sosem volt ilyen könnyű, egyszerű másolások
- párhuzamosítást jobban támogatja (mono alkalmazások esetén rengeteg bottleneck: processing, deadlocks, konkurrencia) --> itt a preemptív OS megold szinte mindent
- load balancing is egyszerűbb
- VM (teljes, hardveres izoláció, de igényes) és containerek (nem teljesértékű OS fut alatta, egy engine allokál erőforrásokat, tehát nem fizikai szeparálás, de kisebb overhead, gyorsabb, egyszerűbb)

##### Konfigurálhatóság

- nem szeretnénk, ha konfigokat, főleg nem forráskódot írni, amikor mozgatni akarjuk a servicet
- deploymentet, tesztelést, monitorozást is egy rendes, átlátható felületen szeretném átlátni (jellemző, hogy weben kattingatunk)
- szinte minden nagy cégnek van felhő szolgáltatása (CLI, REST)

##### Áttérés

Jellemző, hogy a termékek nem microserviceként kezdik meg az életüket, ekkor valahogy át kell térnünk. A megoldás a folyamatos áttérésben van, kiemelünk egy modult microservicebe (ezt jellemzően egy csapat csinálja), és ekkor a meglévő appba facade / proxy / decorator pattern segítségével be tudom integrálni azt. Kisebb kockázatot vállalunk így.

Mit emeljünk ki első lépésben?

- aminek a legkisebb a függősége (mindkét irányba)
- ami gyakran változik, de nem igazán függő (pl.: nyomtatás)
- adatbázis problémák, hiszen izoláltak a servicek --> nem használnak közös adatbázist. Viszont, ha el akarunk érni egy entity-t, annak létezőnek kell lennie az éles adatbázisban, kell valamilyen megfeleltetés
    - idegenkulcsok függése (remote foreign keys megoldás lehet, de nehéz implementálni))
    - adatbázis-klaszter, tényleges elosztott DB rendszer --> CAP
        - konzisztens (mindig pontos, friss adat), azonnal elérhető, partíció toleráns (tovább működik sok kérésnél is)
    - egy közös adatbázis megoldás: szuverenitás sérül, de lehet jó megoldás (ráadásul monolitikus DB problémái előjönnek: skálázhatóság, load balance)

##### Technológiai függetlenség

Megvalósítás során tetszőleges programnyelv használható a különböző servicekhez, de ezeknek kell tudni kommunikálni.

WCF ABC

- Address: szerver - kliens kapcsolat (kétirányú)
- Binding: meg kell egyezni, hogy milyen formában van kommunikáció (jellemző REST API, JSON. REST igazából csak egy filozófia, nem egy rendes protokoll)
- Contract: mindenfajta adattovábbítási adathalmazt definiál (milyen adat küldődik)

##### A mikroszervíz belső felépítése

- a REST API előnye, hogy kívülről egyértelmű, csak egy REST API hívást látok
- belül már bonyolultabb a dolog, mert más-más REST API-val kezelem a desktopot, a mobilt
- elképzelhető, hogy ugyanazt a REST API-t használjuk belül, de tényleg kaotikus lesz egy idő után

 Megoldás: mediator minta

 - nem kell ismerni a ms végpontokat
 - üzenetbusz / csillag topológia
 - address, binding adott, contractot kell csak megállapítani
 - N-N kapcsolat is lehetséges, mert elég csak a mediatort ismerni
 - nagy mennyiségű, kis méretű adatok továbbítása --> IoT

 El kell dönteni, hogy melyik típusú message bust használjuk:

 - megbízhatóság (hányszor kell elküldeni az adatot)
 - sebesség (üzenet / másodperc, de ezt nehéz meghatározni a sok tényező miatt)
 - üzenet mérete (nagyon kicsi és nagyon nagy üzenetek jellemzők, ezek élesen elválnak egymástól)

Megvalósítás:

- "Ad-hoc" módszer: mindenki kommunikál mindenkivel, közös adatbázis is lehet
- Facade / proxy: első esetben nem változtat a kérésen és a válaszon, a proxy változtathat
- Cor
- Branch (fastruktúra)
- Mediator (message bus / broker(több feladó, több címzett))

RabbitMQ

- AMQP protokoll: teljeskörű, nyílt, mindenre kiterjed, mindent definiál. Rengeteg feature, küldési módszerek, útválasztás stb szabályozható --> hatalmas overhead. Felhasználható távoli küldésre, nagyobb fájlokhoz.
- MQTT: kevesebb feature, kisebb overhead, kisebb üzenetek, mobil, IoT, publish-subscribe elv
- RabbitMQ: hybrid (mindent magában foglal, több protokoll), broker is, viszont limitált az üzenetszám, mivel CPU-igényes
- 20-30k üzenet / sec felett mindenképpen MQTT bróker kell 
    - HiveMQ - jól programozható, integrálható
    - Redis - DB + cache, és jó funkciók
    - Apache Kafka - hatalmas teljesítmény, de nem MQTT alapú

Felhasználás

- lanon belül MQTT tökéletes
- weben REST, AMQP dominál

#### Összefoglalás

##### Microservice hátrányok

- erőforrásigény, infrastruktúra
- szaktudás nagyon broad kell legyen, rengeteg stack egyben
- kódot nagyon nehéz újrahasznosítani
- elosztott adatbázis gyengébb, mint egy RDBMS
- hiba stacktrace nincs, nem tudjuk követni rendesen
- kommunikációs overhead nagyon jelentős
- virtualizációs overhead is jelentősebb, mint monolitikus esetben
