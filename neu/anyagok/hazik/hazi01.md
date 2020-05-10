# Programozás házi feladat 2020.05.10

### Határidő: 2020.05.15 23:59

### Leírás

#### Első lépések

> Töltsd le az ezen a [linken](https://www.kerteszgabor.github.io/neu/anyagok/hazik/raktar.txt "raktar.txt linkje") elérhető *raktar.txt* állományt.  
> Egy adatsor felépítése: `gyümölcsnév;mennyiség;egységár`, ahol a mennyiség **lebegőpontos szám**, tehát nem egész, tizedesvesszőt tartalmazhat!  
> Az adatok tárolására alakíts ki egy osztályt, majd az ennek a típusnak a példányait tartalmazó `List<T>` szerkezetbe olvasd be az adatokat!
> Használhatsz konzol- és formos alkalmazást is.

#### Az adatokhoz kapcsolódó feladatok

Határozd meg a következő kérdésekre a választ LINQ függvények, és lamdba-operátorok segítségével!

1.  Határozd meg, hány *k* betűvel kezdődő gyümölcsnév van!
2.  Mennyibe kerül a legdrágább gyümölcs (mennyi az egységára)?
3.  Melyik a 2-es pontban talált legdrágább gyümölcs?
4.  Mennyi a raktár összértéke? (az **összes** gyümölcsöt figyelembe vesszük, és egységár * mennyiség módon számolunk)
5. Az adatok összekeveredtek. Rendezd őket ABC sorrendbe a gyümölcsök neve alapján! (segítség: az angol *order* szó utal jellemzően a rendező algoritmusokara, és az ABC sorrend tekinthető "csökkenő" sorrendnek)