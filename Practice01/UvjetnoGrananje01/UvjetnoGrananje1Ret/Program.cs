

int i = 1;
bool uvjet = i > 0;
if (uvjet)
{

    Console.WriteLine(uvjet);


}

if (uvjet == true)
{
    Console.WriteLine(uvjet);
}

if (!uvjet)
    Console.WriteLine("3: Nije veće od 0");
Console.WriteLine("4: Ovo opet nebi trebalo biti veće od 0");

string grad = "Osijek ";
if (grad == "Osijek")
{
    Console.WriteLine("5: SUPER");
}
else
{
    Console.WriteLine("6: OK");
}

//----------------------------------

int b = 0;
if (grad != "Zagreb")
{
    b = b + 1;
}
else if (grad == "Split")
{
    b += 1;
}
else if (grad == "Osijek")
{
    b += 2;
}
else
{
    b++;
}
Console.WriteLine("7:" + b);
//----------------------------------

i = 5; b = 2;
if (i > 0)
{
    if (b == 2)                                                       //ispisat ce se ako su oba uvjeta zad
    {
        Console.WriteLine("8: Oba uvjeta su zadovoljena");
    }
}

//----------------------------------

if (i > 0 & b == 2)                                     //and(&) funkcija za lakse 
{
    Console.WriteLine("9: Oba uvjeta su zadovoljena");
}

//----------------------------------

if (i > 0 && b == 2)
{
    Console.WriteLine("10:Oba uvjeta su zadovoljena"); //sa duplim and on provjerava samo prvi ako prvi en valja drugi ence ni gledat sto ustedu vrijeme
}


//----------------------------------

if (i == 5 | b < 0)    //znak | je ili (altgr+W) || provjerava samo prvi
{
    Console.WriteLine("napisi da");
}

//---------------------------------- //ZNAK ZA NOT JE ! <<<<<

int g = 10;
if (g % 2 == 0) //ostatak pri djeljenju s 2 je 0
{
    Console.WriteLine("11 broj je paran");
}
else
{
    Console.WriteLine("12: broj je neparan");
}


//kraci zapis ide
Console.WriteLine("broj je" + (g % 2 == 0 ? "" : "ne") + "paran");
//----------------------------------

//prvi zad (korinsik unosi cijeli broj ,za broj kmanji od 10 ispisuje se osijek a inace donji miholjac)
Console.WriteLine("korisnik unosi cijeli broj:  ");
int broj = int.Parse(Console.ReadLine());
if (broj < 10)
{
    Console.WriteLine("Osijek");                        //uvijek kad ocu uneti broj moram imati int.parse
}
else
{
    Console.WriteLine("Donji Miholjac");
}

//----------------------------------
//2 zad, korisnik unosi cijelu broj a program ispiusje je li paran ili nije
Console.WriteLine("Korinsik unosi jedan prirodan broj");
int brojilo = int.Parse(Console.ReadLine());
if (brojilo % 2 == 0)
{
    Console.WriteLine("Unos je paran");
}
else
{
    Console.WriteLine("Unos je neparan");
}
//----------------------------------
//za dva unesena cijela broja, program ispisuje osijek ako je zbroj veci od 10 a inace ispisuje edunova
Console.WriteLine("Unesi prvi cijeli broj:  ");
int br1 = int.Parse(Console.ReadLine());
Console.WriteLine("Unesi drugi cijei  broj");
int br2 = int.Parse(Console.ReadLine());

int rez = (br1 + br2);
if (rez < 10)
{
    Console.WriteLine("Osijek");
}
else
{
    Console.WriteLine("Edunova");
}

//nizovi
int t1 = 2;
int t2 = 3;
int t3 = 12;
int t4 = 14;

//deklaracija niza

int[] niz;

//konstruiranje niza
niz = new int[3];

niz[0] = t1;
niz[1] = t2;
niz[2] = t3;

;Console.WriteLine(niz[2]); //zadnji broj u nizu

//jednodimenzionalni niz
int[] podaci = { 2, 3, 23, 2, 2, 2, 3, 3, 22 };

//dvodimenzionalni niz
int[,] tablica = new int[3, 3]; //tablica sa 9 podataka

//trodimenzionalni niz
int[,,] kocka = new int[3, 3, 3]; //27 podatala

//nizovi u C# mogu imati do 32 dimenzije