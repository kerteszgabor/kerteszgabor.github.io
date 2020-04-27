# Projektmunka visszajelzés 11c

> Ha kérdés van, keressetek Discordon vagy [messengeren](https://www.messenger.com/t/kerteszgabor.official)!  
> Az elfogadva akkor kerül be, ha teljesen green-light a projekt, és nincs mit rajta módosítani azon kívül, amit írtam esetleg! 
> Amíg nem **OK** az elfogadva, addig keressetek meg kérlek, hogy meg tudjuk beszélni a feladatot!

|Név   	|Megjegyzés   	|Elfogadva   	|
|---	|---	|---	|
|Mészáros Dominik   	|Teljesen jó, de ne egy tulajdonságban tárold el az adatokat, hanem csinálj rá külön adattagokat/auto propertyket! pl minden szoftvernek van `public int MemoriaIgeny{}` tulajdonsága, stb...   	| OK  	|
|Molnár Melinda   	    |Jó lesz, dobjuk majd még fel egy-két dologgal, hogy kicsit izgibb legyen, de a szerkezet teljesen jó. Pl. amit mondtam is szerintem, hogy bizonyos időközönként frissül a RAM, azt Timerrel meg lehet oldani, talán másnak is fog ilyen kelleni, majd rakok fel hozzá egy rövid leírást, hogy kell használni.   	|  OK 	|
|Plachi Szilárd   	    |Ez így nagyon kevés, 5 szó az nem egy projekt tervezet  	|   	|
|Soltész Dávid   	    |Jó lesz, de mindenképpen legyenek saját osztályok (örökléssel stb..), ne csak a már megírtakat használd   	| Maybe  	|
|Vaszta Mátyás   	    |Alapötlet jó, de bővítsük ki még olyanokkal, hogy van egy összefogó osztály, ami mondjuk csatateret reprezentál, ebben tudod tárolni a hajókat, ilyenek. A megjelenítés talán Formon nehéz lenne, esetleg egy konzolnak nekiugorhatnál, ahol mondjuk valamilyen karakter reprezentálja a hajó fajtákat, ezek ha közel kerülnek egymáshoz harcolhatnak vagy valami, de ez már nagyon sok meló, szóval csak ha van kedved. Valami alap megjelenítés jó lenne azért a listboxokon meg a gombokon túl    	| OK  	|
|Szabó Richárd   	|Szerintem teljesen jó, ha gondolod, a megjelenítés lehetne úgy megoldva, hogy ha kiválasztunk egy fegyvert annak megjelennek az adatai (ezeket adattagokként tárolod ugye az osztályban), illetve mellé egy kép mondjuk nagyban, hogy hogy néz ki. Ezt úgy lehet megoldani nagy vonalakban, hogy adattagként eltárolod a kép nevét, és eltárolod minden fegyver példányhoz, lásd lejjebb.  |OK   	|
|Sulyok Dániel   |Jó nehéz feladat, de jó ötlet. Ezt a problémát úgy hívják, hogy 0-1 hátizsák probléma. A lényege, hogy adott egy maximális keret, és ezt kell a legoptimálisabban megtölteni termékekkel. Dinamikus programozással, ún. mohó algoritmussal lehet megoldani a problémát. https://youtu.be/8LusJS5-AGo, ezt nézd meg, és majd beszéljünk róla!   |OK   |
|Zágoni Bence   |Nagyon kevés a leírás, és ez amúgy is egy-az-egyben az arénás feladat. Találj ki mást, várom!   |   |
|Leibinger Bence   |Jó lesz, nem is nagyon kell bonyolítani, ez bőven elég  |OK   |

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