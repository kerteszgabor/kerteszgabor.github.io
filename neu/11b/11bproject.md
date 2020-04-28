# Projektmunka visszajelzés 11b

> Ha kérdés van, keressetek Discordon vagy [messengeren](https://www.messenger.com/t/kerteszgabor.official)!  
> Az ajánlott jegyet el tudod fogadni, akkor az kerül be a naplóba 200%-os jegyként. Ha jobbat szeretnél, küldd el újra a munkát feljavítva!

<div class="alert alert-warning alert-dismissible fade show" role="alert">
  <strong>Hali!</strong> Az ötösök és egyesek automatikusan bekerülnek, illetve a csillagos ötös +1 50%-os ötös:)
  <button type="button" class="close" data-dismiss="alert" aria-label="Close">
    <span aria-hidden="true">&times;</span>
  </button>
</div>

<div class="alert alert-success alert-dismissible fade show" role="alert">
  <strong>A csillagok pedig...</strong> A csillagos ötös az +1 50%-os ötös:)
  <button type="button" class="close" data-dismiss="alert" aria-label="Close">
    <span aria-hidden="true">&times;</span>
  </button>
</div>

|Név   	|Visszajelzés   	|Ajánlott jegy   	|
|---	|---	|---	|
|Egbomon Michael   	| Jó lett, igényes munka. Extra funkciók lehetnének még a számla fájlba írása esetleg, de így is teljesen oké persze.	| 5   	|
|Schvorczi Gergő   	|Ez is igényes munka, meg látszik, hogy foglalkoztál vele. |5	|
|Turza Máté   	|Nagyon jó amit eddig csináltál, kár, hogy az összehasonlítások nem lettek kész. Ha gondolod, ötösért fejezd be azt is. | 4 	|
|Várhegyi Roland   	|Nem kaptam semmit 	|1 	|
|Varga Marcell   |Nem kaptam semmit  |1 |
|Vilmánszki Marcell   |Nem kaptam semmit |1   |
|Kövér Szabolcs   |Amit csináltál, az jó, csak sajnos kevés (már a tervezetnél is írtam). Abszolút semmit nem interaktálnak egymással az osztályok, csak vannak. Ez kb alapnak jó egyelőre  | 3  |
|Szöghy Richárd   |Király :D mondjuk én Demogorgon szerettem volna lenni :D de tényleg szép munka különben, és köszi a részletes dokumentációt  |5*   |
|Vörös Csanád   |Tetszett a háttér, meg az állatok:) Szép munka! |5   |
|Zengő Zoltán   |Tetszik, jó sokat dolgozhattál vele. Ha kicsit többet foglalkoztál volna az OOP-val, akkor ezt a 3k sort szerintem le lehetett volna redukálni kb 1000 sorra. Persze az sem kevés, de az ismétlődő kinullázások pl mind megoldhatóak ciklusokkal. Ettől független, az effortért, meg a sok funkció miatt adok plusz ötöst. Örülnék, ha jövőre órán is kicsit aktívabb lennél, meg figyelnél, mert tök jó dolgokat tudnál csinálni azzal a tudással, amit ott veszünk | 5*  |

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