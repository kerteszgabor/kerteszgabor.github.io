# Prog4 nyolcadik előadás

> Disclaimer: az anyag kiegészítésül szolgál az előadás hivatalos anyagához. Ami nem szerepelt a dián, de elhangzott, és esetleg a vizsgán is hasznos lehet, az itt olvasható.

## MVC design pattern

### Alapfogalmak

- URL / URI: feladatuk a távoli lokáció, hogy ne kelljen elérési utakat pötyögni
- HTTP: nincs state-tracking
- Probléma, hogy a request-response után egy kapcsolat `connection closed`
- Ez utóbi azonosítási problémákhoz vezet, hiszen a usecase-ket nem lehet követni
- Dinamikus weboldal: (esetleg paraméterezett) kérés után, a szerveren egy program lefut, és annak az eredményét kapja vissza a kliens
- CGI alkalmazások: standard input-output használó alkalmazások, kezdeti megoldás, hisz itt a végrehajtás nem a webszerver maga, hanem külső alkalamzás
- Jellemzően modulos megközelítés terjedt el

### ASP .NET

Szerveroldali C# alapú webes keretrendszer.

- első verziója az ASP WebForms, ez ma már deprecated
- csak Windowsos környezet
- .NET Core verzió alatt már saját, **platformfüggetlen** webszerver van
- Linuxon és MacOS-en is futtatható, önmagában a .NET Core Kestrel szervere nem tud sok mindent, szóval jelelmzően elé jön egy Apache vagy Nginx proy szervernek
- terheléselosztás nagyon jól megvalósítható
- teljesen moduláris már, csak azt telepíti, ami library-re szükség van

#### Alapok

- AppData mappába **kézzel** be kell másolni az adatbázist
- Web.config-ban mindent be lehet állítani, kivéve a hostolást, ez a project propertiesben kell konfigolni
- workflow eltér az MVVM-től: egy gombon kattintás = URL beírása, és ez hív egy controller metódust
- Controller nem végez BL műveletet, csak irányít
- itt model = domain model = adatmodellek + logika

> Mi is az a model és viewmodel?  

Van lehetőség ViewModelre MVC esetén is, azonban ez nem az MVVM VM-je. Itt ugyanis a VM-ben nincs se esemény, se command. El tudjuk azonban képzelni azt az esetet, amikor a viewnak egy egyszerű dolgot kell megjelenítenie, amit rögtön a logikától meg is kap a controller segítségével, ekkor gyakorlatilag a controller nem is releváns, és mivel a BL itt a model része,így az útvonal: **Model-->View**, tehát gyakorlatilag ViewModel  
A model nagy vonalakban való tervezés esetén használható szó, de konkrét architektúrális tervezés esetén alkalmatlan szakmai jelleg kifejezésére.

Fontosabb modellek, amiket ismerünk: (vizsgán ismerni kell őket)
- Form model
- Domain model
- Entity Model
- View model

Workflow a következőképpen néz ki a mi esetünkben:

|1. lépés   |2. lépés   |3. lépés   |4. lépés   | 5. lépés  |6. lépés   | 7. lépés  |   8. lépés|
|:-:|:-:|:-:|:-:|:-:|:-:|:-:|:-:|
|User request   |Controller metódusa meghívja a logicot   |Logic meghívja a repot   |Repo->EF->Logicnak entity modellek   |Logic entity modelleket ad a controllernek   |  Controller kiválasztja a view-t |Controller megkeresi és feltölti a megfelelő modellekkel a viewt (EM != model)   |  HTML válasz visszaküldése|

