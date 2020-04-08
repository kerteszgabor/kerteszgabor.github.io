# Projektmunka visszajelzés 11b

> Ha kérdés van, keressetek Discordon vagy [messengeren](https://www.messenger.com/t/kerteszgabor.official)!  
> Az elfogadva akkor kerül be, ha teljesen green-light a projekt, és nincs mit rajta módosítani azon kívül, amit írtam esetleg!

|Név   	|Visszajelzés   	|Elfogadva   	|
|---	|---	|---	|
|Egbomon Michael   	|Jó az alapötlet nagyon, de a leszármaztatást nem biztos hogy jól gondoltad ki. A szálloda legyen egy összefogó típus, és abban legyenek benne esetleg egy `List<Vendeg> vendegek` kollekció, meg egy `List<Szoba> szobak`. Ezt hívjuk osztályok kompozíciójának, mert *egybeépíted* az osztályaidat gyakorlatilag. Az öröklődést inkább úgy oldanám meg, hogy `Szoba` ősosztály, és vannak különleges szobák, amik ebből származnak le. Majd még Discordon beszéljünk egyszer róla pls!   	|Maybe   	|
|Schvorczi Gergő   	|Jó az alapötlet, de bővítsük még ki egy kicsit, mert elég kevés a funkcionalitás. Pl. megjelenítés azért a labeleken kicsit túlmutathat, vagy valami. De a logikát is meg kéne egy kicsit komplikálni. Majd Discordon beszéljünk róla valamikor, kérlek!  	|Maybe   	|
|Turza Máté   	|Ez teljesen jó, elég bonyolult a szűrések miatt. Ha gondolod, esetleg a kocsikhoz képet is lehet majd rakni, ehhez rakok lejjebb neked egy kis kódot, hogy lásd nem olyan bonyolult, de sokkal jobban fog kinézni a program, ha tetszik az ötlet, majd beszéljünk róla.   	|OK   	|
|Várhegyi Roland   	|Egész jó, tudjunk összehasonlítani objektumokat minden szempont alapján, amiket írtál. Még agyalj valami plusz funkción esetleg, mert egy kicsit vérszegény az a része   	|OK   	|

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