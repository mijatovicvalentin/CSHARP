

//while radi sa bool tipom podatka

//ovo je beskonacna petlja


while(true)
{
    break;  //izlaz iz beskoancne petlje
}

//u for se ne mora uci
int i = 0;
for(i = 0; i < 0;  i++)
{
    Console.WriteLine("01 nisam ušao");
}

// u while se ne mora auci

while(false)
{
    Console.WriteLine("02 Nisam ušao");
}

int b = 0;

while(b<10)
{
    Console.WriteLine(++b);
}

Console.WriteLine("*********************");

int t = 2;
b =0;
while(t==2 && b<10)
{
    Console.WriteLine(++b);
}

Console.WriteLine("*********************");
b= 0;
while (true)
{
    if (b == 2) 
    {
        b++;
        continue;
    }
    if (b == 5) {
        break;
    }
    Console.WriteLine(b++);
}

Console.WriteLine("*********************");
//program unosi broj između 1 i 10
//program  ispisuje uneseni broj

while(true)
{
    Console.Write("Unesi cijeli broj:   ");
    b = int.Parse(Console.ReadLine());
    if (b>0 && b<=10)
    {
        break;
    }
    Console.WriteLine("Morate unijeti broj između 1 i 10");
}
Console.WriteLine("Uneseni broj je {0}", b);

Console.WriteLine("*********************");
//Napišite program koji pomocu while petlje ispisuje svaki treci broj izmedju 2 i 97
b = 2;
while (b <= 97)
{
    Console.WriteLine(b);
    b += 3;
}



Console.WriteLine("*********************");
//zbrojite prvih 100 brojeva sa while petljom

int zbroj = 0;
b = 0;
while(b++<100)
{
    zbroj += b;
}
Console.WriteLine(zbroj);
//pojednostavljeno
zbroj = 0;
b = 1;
while(b<=100)
{
    zbroj += b;     //bolji nacin
    b++;
}
Console.WriteLine(zbroj);
Console.WriteLine("*********************");

// ///////////////////////
///////////////// DO PETLJA(DO WHILE)////////
//do petlja osigurava minimalno jedno izvođenje
//zato što je uvjet na kraju petlje

//sintanksa
do
{
    Console.WriteLine("01 Ušao u petlju");
} while (false);
//do while se koristi kad smo sigurni da se nešto
//mora jednom izvesti

//ostalo sve kao u for i while

//korisnik unosi 2 cijela broja između 10 i 20
//program ispisuje sve parne brojeve između unesenih brojeva
// koristiti do petlju

int br1 = 0;
int br2 = 0;

do
{
    Console.Write("Unesi prvi cijeli broj: ");
    br1 = int.Parse(Console.ReadLine());
    if (br1 >= 10 && br1 <= 20)
    {
        break;
    }
    Console.WriteLine("Broj nije između 10 i 20!");
}
while (true);

do
{
    Console.Write("Unesi drugi cijeli broj: ");
    br2 = int.Parse(Console.ReadLine());
    if (br2 >= 10 && br2 <= 20)
    {
        break;
    }
    Console.WriteLine("Broj nije između 10 i 20!");
}
while (true);

int manji = br1 < br2 ? br1 : br2;
int veci = br1 > br2 ? br1 : br2;
int j = manji;

do
{
    if (j % 2 == 0)
    {
        Console.WriteLine(j);
    }
}
while (++j <= veci);

//---------------------------------------------
//FOR EACH PETLJA
int[] niz = { 2, 3, 4, 5, 5 };

    for(int l = 0;l < niz.Length; l++)
{
    Console.WriteLine(niz[l]);
}

Console.WriteLine("************************");
for (int l = niz.Length - 1; l >= 0; l--)
{
    Console.WriteLine(niz[l]);
}
Console.WriteLine("************************");
foreach (int en in niz)
{
    Console.WriteLine(en);
}
//CIKLIČNA MATRICA//
Console.WriteLine("************************");


