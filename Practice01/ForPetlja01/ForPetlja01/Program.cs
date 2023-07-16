
Console.WriteLine("1. ****************");

for (int i = 0; i < 10; i = i + 1)
{
    Console.WriteLine("Osijek");
}


// Brojač se ne mora povećavati, može se i smanjivati


Console.WriteLine("2. ****************");

int j = 0;
for (j = 10; j > 0; j--)
{
    Console.WriteLine("Edunova");
}





 


// DZ vježbati s Break point i debug



Console.WriteLine("3. ****************");

for (int i = 0; i < 10; i = i + 2)
{
    Console.WriteLine("CSHARP");
}




// varijabla u petlji mijenja svoju vrijednost!

Console.WriteLine("4. ****************");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

//Ispisat će brojeve od 0 do 9


// Korisnik ne voli vidjeti 0, očekuje brojeve od 1 do 10

Console.WriteLine("5. ****************");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + 1);     // ovdje i+1 ne mijenja vrijednost varijable, samo ju ispisuje
}



Console.WriteLine("6. ****************");

//drugi način
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);     // ne koristiti!
}

Console.WriteLine("7. ****************");

// zbroj prvih 100 brojeva

int zbroj = 0;

for (int i = 1; i <= 100; i++)
{
    // Console.WriteLine(i);	-> nema potrebe da ispisujemo svaki broj
    zbroj += i;   //   to je isto kao zbroj=zbroj+i
    // Console.WriteLine(zbroj);	-> nema potrebe da ispisujemo trenutni zbroj
}

Console.WriteLine(zbroj);		// treba nam samo konačan zbroj

Console.WriteLine("8. ****************");

// Ispisati sve parne brojeve između 1 i 57

for (int i = 1; i <= 57; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("9. ****************");

// ispiši zbroj svih parnih brojeva između 2 i 18

zbroj = 0;
for (int i = 2; i <= 18; i++)
{
    if (i % 2 == 0)
    {
        zbroj += i;
    }
}

Console.WriteLine(zbroj);

Console.WriteLine("10. ****************");


int[] niz = { 2, 2, 34, 54, 5, 6, 76, 7 };

// jedno ispod drugog ispisati svaki element niza

for (int i = 0; i < niz.Length; i++)
{
    Console.WriteLine(niz[i]);
}


// Program učitava koliko će se brojeva unijeti
// Program učitava brojeve za provjeru
// Program ispisuje najveći uneseni broj

Console.Write("Unesi koliko brojeva provjeravaš: ");
int brojeva = int.Parse(Console.ReadLine());
int broj;           // nikada ne deklarirati varijablu unutar petlje, uvijek izvan!
int najveci = int.MinValue;  // prije početka najvećem dodijelimo najmanju vrijednost

for (int i = 0; i < brojeva; i++)
{
    Console.Write("Unesi {0}. broj: ", i + 1);
    broj = int.Parse(Console.ReadLine());
    if (broj > najveci)			// provjerava je li trenutni broj veći od najvećeg
    {
        najveci = broj;		// ako da, sada je on najveći
    }
}
Console.WriteLine("Najveći broj je {0}", najveci);



// ovo nije beskonačna petlja, jer nakon najvećeg broja idemo u minus, tj. dobivamo najmanji broj (sjeti se, brojevi ovdje nisu na brojevnom pravcu, nego na brojevnoj kružnici!)

for (int i = 1; i > 0; i++)
{

}

// ovo je beskonačna petlja, jer dijelovi u zagradi nisu obavezni

for (; ; )
{
    Thread.Sleep(1000);     // Ovo napišemo ako želimo da sporije ispisuje brojeve
    Console.WriteLine(new Random().NextDouble());    // loša sintaksa
}



//Nasilno prekidanje petlje -> naredba break;
//for (; ;)
// {
//    Thread.Sleep(1000);
//    Console.WriteLine(new Random().NextDouble());    // loša sintaksa
//    break;        // nasilno prekidanje petlje
// }





Console.WriteLine("12.  ****************");

for (int i = 0; i < 10; i++)
{
    if (i == 3)
    {
        break;
    }
    Console.WriteLine(i);
}



// petlja se može nastaviti/preskočiti

Console.WriteLine("13.  ****************");

for (int i = 0; i < 10; i++)
{
    if (i == 2 || i == 5)
    {
        continue;
    }
    Console.WriteLine(i);
}

//Ovdje će ispisati brojeve od 0 do 9, ali će preskočiti brojeve 2 i 5


// ugnježđivanje petlji

Console.WriteLine("14.  ****************");

string s;
for (int i = 1; i <= 10; i++)        //dok je i=1, k se prošeće od 1 do 10
{						// onda se i poveća za 1, pa k opet ide od 1 do 10…
    for (int k = 1; k <= 10; k++)
    {
        s = "    " + i * k;
        Console.Write(s[^4..]);       // ispisat će tablicu množenja, lijepo poravnato
                                      // string je niz znakova, a trebamo zadnja 4 znaka
                                      // da svi brojevi budu poravnati s desne strane
    }
    Console.WriteLine();        // kada završi unutarnja petlja, prijeći će u novi red
}


// DZ
//		Kreiraj program koji će koristeći for petlje
//		automatizirati ispis tablice množenja u ovom obliku:
//		-------------------------------
//		: : :  TABLICA  MNOZENJA  : : :
//		-------------------------------
//		 * |  1  2  3  4  5  6  7  8  9
//		-------------------------------
//		 1 |  1  2  3  4  5  6  7  8  9
//		 2 |  2  4  6  8 10 12 14 16 18
//		 3 |  3  6  9 12 15 18 21 24 27
//		 4 |  4  8 12 16 20 24 28 32 36
//		 5 |  5 10 15 20 25 30 35 40 45
//		 6 |  6 12 18 24 30 36 42 48 54
//		 7 |  7 14 21 28 35 42 49 56 63
//		 8 |  8 16 24 32 40 48 56 64 72
//		 9 |  9 18 27 36 45 54 63 72 81
//		-------------------------------
//		:  :  :  :  :  :   :by Tomislav
//		-------------------------------
//		Umjesto "Ime" treba ispisati ime uneseno s konzole i pri tome pripaziti da 
//		zadnje slovo imena bude poravnato s desnim rubom tablice.



// nasilno prekidanje unutarnjih petlji

for (int i = 0; i < 10; i++)
{
    for (int k = 0; k < 10; k++)
    {
        // break;  		
        goto labela;    
}

labela:;







Console.WriteLine("Unesi prvi prirodan broj: ");
int pb = int.Parse(Console.ReadLine());
Console.WriteLine("Unesi drugi prirodan broj: ");
int db = int.Parse(Console.ReadLine());

int manji = pb < db ? pb : db;  
int veci = pb > db ? pb : db;   

for (int i = manji; i <= veci; i++)
{
    zbroj = i % 2 == 0 ? zbroj + i : zbroj;  
}
Console.WriteLine(zbroj); 




int t = 100;
for (int i = 0; i > t; i++)    
{
    Console.WriteLine("Ušao u petlju");
}




for (int i = 100; i > 0; i--)
{
 
       Console.Write(i + (i != 1 ? "," : ""));
}