# Projektmunka visszajelzés 11c

> Ha kérdés van, keressetek Discordon vagy [messengeren](https://www.messenger.com/t/kerteszgabor.official)!  

<div class="alert alert-success alert-dismissible fade show" role="alert">
  <strong>Hali!</strong> Jegyek a naplóban.
  <button type="button" class="close" data-dismiss="alert" aria-label="Close">
    <span aria-hidden="true">&times;</span>
  </button>
</div>

|Név   	|Megjegyzés   	|Jegy   	|
|---	|---	|---	|
|Mészáros Dominik   	|Az ős konstruktora nem csinál semmit, az adattagokat ott kellett volna beállítani, és nem a leszármazottakban. A Paintnél a képet nem így kellett volna beállítani, hanem ahogy lent írtam a Ricsinek. Van egy metódusod, ami bekér egy képet, és visszadja azt, tehát nem csinál semmit:) A beolvasásban pedig a `else if (sor[0] == "Paint")` elég durva hard coding. :D Ez most sajnos nem sikerült olyan jól, mint szokott, sajnálom :/ | 3 	|
|Molnár Melinda   	    |Kicsit sok a kódismétlés, a beolvasást meg lehetne írni rövidebben, illetve a sok labelezés is ilyesmi. Ez lehet az én hibám is, nem nagyon néztük át, hogy kell egyszerre több labelt kezelni, nem tartottam akkor fontosnak, most meg már kvázi nincs rendes óránk:) Amúgy jó munka, az osztályok kicsit vérszegények, egy összehasonlító metódus vagy egy <> operátor felülírás elfért volna még. |  4/5 	|
|Plachi Szilárd   	    |Nem kaptam semmit, tudom, hogy kórházban voltál, de már előtte kellett volna valaminek készülni. Úgy tudom múlt héten kiengedtek, de azóta sem került fel semmi. | 1  	|
|Soltész Dávid   	    |Azt hiszem múltkor megbeszéltük a dolgot. Ennyit tudtam erre adni, sajnálom :/| 1/2  	|
|Vaszta Mátyás   	    |Hú Matyi, ez most nagyon nem adta ki sajnos. Azok az ifek, amik beterítik a képernyőt biztosan nem a jó megközelítései a dolognak. Az OOP lényeg meg elveszett így. Ha érdekel mi lett volna a jó irány, ezt találtam a neten: https://exceptionnotfound.net/modeling-battleship-in-csharp-components-and-setup/ | 2  	|
|Szabó Richárd   	|Csak összeállt ez:) mondjuk a végére az ősosztályban lettek fura dolgok, kicsit kesze-kusza, de sebaj. A másik, hogy a lista elemeinek megszámolására segédváltozót fenntartani felesleges, hiszen `fegyok.Count` éppen ezt adja meg, de ez csak apróság. |5   	|
|Sulyok Dániel   |Ez kb ugyanaz, mint amit a múltkorra leadtál. Az már egész jó volt, de írtam kódot hozzá, amit csak be kellett volna másolni konkrétan, viszont ez nem történt meg. | 4   |
|Zágoni Bence   |Nem kaptam semmit |  1 |
|Leibinger Bence   | Nem kaptam semmit |1   |

<hr>

## Félkész projektek visszajelzése

|Név   |Megjegyzés   |Jelenlegi jegy   |
|---	|---	|---	|
|Molnár Melinda   | Egész jó, a karakterkódolás az ismertetőben fura, meg mintha nem lennének ékezetek, majd nézd meg esetleg. | 3 |
|Sulyok Dani   |Nagyon tetszik, nagyon jól működik. Az osztályöröklődés annyira így viszont nem jó, lent leírom, szerintem hogy kéne.   | 4  |
|Szabó Ricsi   |Szerintem jó lesz, lejebb nézd meg amit írtam! | 2   |
| Vaszta Matyi  |Jó  lesz, osztályok jók, látom megjelenítés is van, viszont most jönne a szívós játéklogika mögé :D Kicsit még keveset foglalkoztál vele, de ha kész lesz, jó lesz    | 1/2  |


## Egyéni kód segítségek

### Szabó Ricsi
A `KepPath` nyugodtan mehet adattagnak+hozzá tulajdonság az ősbe, és akkor minden fegyónál be tudod állítani a képet. Megjelenítés: 

<img src="beadott\felkesz\Szabó Richárd Attila_74190_assignsubmission_file_\fegyo.png"
     alt="Fegyó"
     class="img-responsive center-block" />

Húzz fel egy `PictureBox`-ot, majd válaszd ki a listboxodat, amiben az elemek vannak, ekkor a properties fülön a kis villámnál, ahol az események vannak, keresd ki a `SelectedIndexChanged` eseményt, dupla katt bele, majd:

```cs
namespace Szabó_Richárd_Projekt
{
    public partial class Form1 : Form
    {
        List<Weapons> fegyok = new List<Weapons>(); // itt tárolom a fegyókat
        public Form1()
        {
            fegyok.Add(new Sheriff());      // csak egy mintát hozzáadtam
            InitializeComponent();
        }

        private void bt_indit_Click(object sender, EventArgs e)
        {
            foreach (var fegyo in fegyok)
            {
                listBox1.Items.Add(fegyo.ToString());   // overrideold az ős .ToStringjét, úgy, hogy azt írja a listboxba, amit szeretnél
            }                                           // a neveket nem tároltad, de nem baj, mert a .GetType().Name pont ezt adja meg!!
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) // minden egyes kattintáskor, amikor másikat választunk ki a listboxban, ez lefut
        {
            var kivalasztottIndex = listBox1.SelectedIndex;  // ez megadja hányadik elemet választottuk = listában ugyanez az index!!!
            pictureBox1.ImageLocation = fegyok[kivalasztottIndex].KepPath;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
```

### Sulyok Dani

Így kéne helyesen megcsinálni:
```cs 
namespace SulyokDániel_11c_Projekt
{
    abstract class Ososztaly
    { 
        public int Ertek { get; set; }
        public Ososztaly(int ertek)
        {
            this.Ertek = ertek;
        }
        public static string datum = DateTime.Today.ToString();
    }
    class Filmek : Ososztaly
    {
        public Filmek(int ertek) : base(ertek)
        {
        }
    }
}
```
A mentő ablaknál pedig ezzel automatikusan kitölti txt-re alul, szóval jó formátumban menti el:  
`            szamla.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";`  
Ezt még az if előtt szúrd be!
Írj, ha nem annyira érthető! Beszéljük meg