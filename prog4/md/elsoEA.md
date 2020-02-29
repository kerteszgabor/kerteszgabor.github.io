# Prog4 előadások
> Disclaimer: az anyag kiegészítésül szolgál az előadás hivatalos anyagához. Ami nem szerepelt a dián, de elhangzott, és esetleg a vizsgán is hasznos lehet, az itt olvasható.

## 1. előadás

### Grafikus felület API-k és jellemzőik

- Overhead nem lényeges
- Alacsony szinten (pl.: winapi) nem érdemese foglalkozni vele, nem OOP, hülye paraméterezés…
- Erre ráépül egy magasabb szintű layer, a probléma, hogy a frameworkök folyamatosan változnak
- A Windows Forms atomstabil, kiforrott, kényelmes, de alap dolgokat tud, főleg megjelenítésre fókuszál. Nem támogat tervezési patterneket, valamint a megjelenítés és a vezérlés szétválasztása problémás
- WPF-re átállás problémás volt a sok windows forms legacy kód, ráadásul sok IDE crash miatt is az elején
- UWP maga halott, de a core még létező dolog, WinUI néven próbálják integrálgatni a WPF-be
- Cross-platform mobil megoldások (XAML)
- .Net Core fölé lehetett volna egy platformfüggetlen WPF ui-t rakni, de nem ez történt, maradt a csak Windowsos környezet
- MS szerint a megoldás: Web Razor + Native  = Blazor, az új platformfüggetlen UI solution
- WPF-el az MVVM pattern jól látható

### Design Patterns, MV* layering, MVVM vs MVC

- Architekturális tervezési minták (egy doboz nem egy classt reprezentál, hanem classok gyűjteményét)

    #### MVVM

    * Model = üzleti logika
    * Főleg GUI-kra jellemző
    * Viewból üzleti metódust úgy hívok meg, hogy a View Modelt berakom közéjük: absztrakció, tehát nem függnek egymástól
    * Dependency-k csökkentése, egyirányúak legyenenek (view model eseményvezérelt, tehát úgy szól a viewnak, hogy egyirányú kommunikáció)
    * Kétirányú függés: rossz, mert nem tudjuk szétbontani a komponenseket (pl átmozgatás másik appba nem lehetséges, csak együtt)

    #### MVC

    - Itt a model egy egyszerű adathalmaz (tehát kb az MVVM-m view modelje, de az eseményvezérelt, itt viszont validációk vannak; illetve tulajdonságok mind a kettőben)
    - Főleg webes keretrendszerek
    - Itt az interakció, input egyből a kontrollerhez jut el 
    - Request alapján a controller hozza létre view-t a model alapján
    - API hívás esetén (pl REST) nem HTML-t, viewt ad vissza, hanem egy JSON-t &#8594; MVVMC v1

    #### MVVM filozófia:
    
    -	Tulajdonságok halmaza
    -	Automatizáció: adatkötéssel történik 
    -	Adatkötés négy dologból áll: 
        * Forrásobjektum: datakontext megadása &#8594; source Prop.: mindig public tulajdonság
        * Cél vezérlő: dependency object kell legyen mindig &#8594; dest. Prop
        * Jelszóhoz nem tudunk kötni, mert nem lehet destination prop. &#8594; biztonság
        * Tulajdonság módosítása: automatát szeretnék jellemzően, tehát Two-way binding
        * Frissítési metodika: 
            + Property Changed: gyakori, egyből amikor változás van, frissítünk
            + Explicit: ritka, csak amikor én kérem
            + LostFocus: jellemzően textboxoknál használjuk
            + Konverter is van, ha útközben esetleg adatot kéne konvertálni
    - Automata szinkronizáció:
        * UI frissítése nagyon lassú, körülményes feladat
        * Ezért nem folyamatosan frissítgetünk, hanem eventen keresztül értesítjük a view-t (absztrakcióval történik, minden view model implementálja a INotifyPropertyChanged interfészt) 
        * A feliratkozás magától történik, az ablak által, PropertyChanged hatására frissít 
        * A view model dob egy eseményt, nem tud a view-ról &#8594; nincs függés, csak egy irányba!
    - Főleg XAML segítségével érdemes a view modelt létrehozni, de máshogy is lehet
    - UI eventek: kényelmes, de rossz működés… a view küld eseményt a XAML.cs-nek közvetlen, túl sok függés, circle dependency
    - Mi lenne akkor a szép megoldás? Ki kell bővíteni a view model-t
    - Command design pattern: 
        * VM megkapja az interakciót a viewtól, továbbküldi a BL-nak 
        * Itt is egyirányú a függés
        * Így alakul ki a teljes MVVM 
        * Logika **semmiképpen sem** függ az VM-től, tehát decoupled komponensek &#8594; csak egyirányú függés alakul ki


        
