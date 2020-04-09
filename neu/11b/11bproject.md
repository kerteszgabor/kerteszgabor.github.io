# Projektmunka visszajelzés 11b

> Ha kérdés van, keressetek Discordon vagy [messengeren](https://www.messenger.com/t/kerteszgabor.official)!  
> Az elfogadva akkor kerül be, ha teljesen green-light a projekt, és nincs mit rajta módosítani azon kívül, amit írtam esetleg!
> Amíg nem **OK** az elfogadva, addig keressetek meg kérlek, hogy meg tudjuk beszélni a feladatot!

|Név   	|Visszajelzés   	|Elfogadva   	|
|---	|---	|---	|
|Egbomon Michael   	|Jó az alapötlet nagyon, de a leszármaztatást nem biztos hogy jól gondoltad ki. A szálloda legyen egy összefogó típus, és abban legyenek benne esetleg egy `List<Vendeg> vendegek` kollekció, meg egy `List<Szoba> szobak`. Ezt hívjuk osztályok kompozíciójának, mert *egybeépíted* az osztályaidat gyakorlatilag. Az öröklődést inkább úgy oldanám meg, hogy `Szoba` ősosztály, és vannak különleges szobák, amik ebből származnak le. Majd még Discordon beszéljünk egyszer róla pls!   	|Maybe   	|
|Schvorczi Gergő   	|Jó az alapötlet, de bővítsük még ki egy kicsit, mert elég kevés a funkcionalitás. Pl. megjelenítés azért a labeleken kicsit túlmutathat, vagy valami. De a logikát is meg kéne egy kicsit komplikálni. Majd Discordon beszéljünk róla valamikor, kérlek!  	|Maybe   	|
|Turza Máté   	|Ez teljesen jó, elég bonyolult a szűrések miatt. Ha gondolod, esetleg a kocsikhoz képet is lehet majd rakni, ehhez rakok lejjebb neked egy kis kódot, hogy lásd nem olyan bonyolult, de sokkal jobban fog kinézni a program, ha tetszik az ötlet, majd beszéljünk róla.   	|OK   	|
|Várhegyi Roland   	|Egész jó, tudjunk összehasonlítani objektumokat minden szempont alapján, amiket írtál. Még agyalj valami plusz funkción esetleg, mert egy kicsit vérszegény az a része   	|OK   	|
|Varga Marcell   |Nagyon tetszik, jó ötlet! A random sorsolással érzésem szerint baj lesz (hiszen a random generátor nagyon gyorsan fogja pörgetni a pilótákat, így sokszor jöhet ki ugyanaz, vagy nagyon hasonló helyen lévő pilóta stb..), erre rakok lentebb egy megoldást ami sztem működik, de majd ki kéne próbálni   |OK   |

## Egyéni kód segítségek

### Turza Máté

Ilyesmire gondoltam:
```cs
    class Ferrari : Supercar 
    {
        public string Modell {get; set;}
        public int Hengerurtartalom {get; set;}
        
        // stb... egyéb adatok, ezt te tudod

        public string KepPath{ get; set;} = "ferrariKep.jpg" // ferrariKep.jpg meg benne van a debugban
    }
```
És majd a formon lesz egy `PictureBox`, aminek a src-jét fogjuk cserélgetni, ezt majd még megbeszéljük, hogy kéne

### Varga Marcell

Gyakorlatilag arra gondoltam, hogy lassítani kéne a random generálás idejét, illetve pontosabban eltolni őket egymástól. Ugye az a gond, hogy a C# pszeudórandom számai a processzoridőből seed-elődnek, tehát, ha valakik teoretikusan "egyszerre" nyomják meg a gombot (szerintem erre egyébként nincs nagy esély, de jobb biztosra menni), akkor egymáshoz nagyon közeli random számot kaphatnak.
```cs
Random rand = new Random(Guid.NewGuid().GetHashCode());
```
Ezt a randomot minden játékosnál újrapéldányosítanám ebben a formában, és ebből generálnám a randomot.