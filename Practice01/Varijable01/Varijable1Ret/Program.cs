
int varijabla = 4;

Console.WriteLine(varijabla);

// ---------------------------------
int i;

i = 4;

Console.WriteLine(i);
// ---------------------------------

string NizZnakova = "Edunova";
Console.WriteLine(NizZnakova);

// ---------------------------------


int a = 2;
float b = 3.14f;
bool c = true;
decimal d = 83.74m;
double e = 3.14;
string f = "Edunova";
Console.WriteLine("{0},{1},{2},{3},{4},{5}", a, b, c, d, e, f);

// ---------------------------------
Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue);
// ---------------------------------

int z = int.MaxValue;
z = z + 1;
Console.WriteLine(z);


int k = int.MaxValue;
k = k - 1;
Console.WriteLine(k);

// ---------------------------------

Console.WriteLine(5 % 3);
Console.WriteLine(1 % 1);

// ---------------------------------

int x, h, j = 6;
bool istina = j == 6;
Console.WriteLine(istina);

// ---------------------------------

//UlazIzlaz

Console.WriteLine("Unesite broj: ");
int broj = int.Parse(Console.ReadLine());
broj = broj + 7;
Console.WriteLine(broj);

// ---------------------------------


Console.WriteLine("unesi prvi broj:   ");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("unesi drugi broj:   ");
double b2 = double.Parse(Console.ReadLine());

double rezultat = b1 + b2;

Console.WriteLine(rezultat);

Console.WriteLine("unesite prvi broj:  ");
double db01 = double.Parse(Console.ReadLine());

Console.WriteLine("Unesite drugi broj:  ");
double db02 = double.Parse(Console.ReadLine());


double rezultati = db01 / db02;
Console.WriteLine(rezultati);


Console.WriteLine("unesi broj bla bla:  ");
int ab = int.Parse(Console.ReadLine());

Console.WriteLine("unesi drugi broj bla bla:  ");
int ac = int.Parse(Console.ReadLine());

int dalje = ab + ac;

Console.WriteLine(dalje);


// ---------------------------------
//Konverzije


//implicitna
float ff = 7f;
double dd = 7;

//cast
int l = 3;
int r = 4;
float rez = l / r;
Console.WriteLine(rez);

int aj = 3;
int o = 4;
float rezu = aj / (float)o;
Console.WriteLine(rezu);

// ---------------------------------
//Operatori

bool razlicito = 13 != 13;
bool manje = 4 < 7;
Console.WriteLine("{0},{1}", razlicito, manje);


string az = "Grad" + "Osijek";

int xx = 16 + 6;

string s1 = "Broj" + 5;

Console.WriteLine("{0},{1},{2}", az, xx, s1);


Console.Write("Unesi broj01:  ");
x = Int16.Parse(Console.ReadLine());


int negativnibroj = -845;
Console.WriteLine(negativnibroj * (-1));
//dobivanje broja pozitivnog sa puta i u zagradama -1 jer minus daje plus a broj u plusu daje minus


Console.WriteLine("Unesite prvi cijeli broj:  ");
int cb1 = int.Parse(Console.ReadLine());

Console.WriteLine("Unesite drugi cijeli broj:  ");
int cb2 = int.Parse(Console.ReadLine());


float rezul = cb1 / (float)cb2;

Console.WriteLine(rezul);

// DZ
// Za uneseni dvoznamenkasti broj
// ispišite jediničnu vrijednost
// npr unos 21, ispis 1
// npr unos 87, ispis 7


Console.WriteLine("Unesi jedan dvoznamenkasti broj: ");
int dvoznamenkastibroj = int.Parse(Console.ReadLine());
int ostatak = dvoznamenkastibroj % 10;
Console.WriteLine("{0},", ostatak);

Console.WriteLine("Unesi jedan dvoznamenkasti broj: ");
int dvoznamenkastibr  = int.Parse(Console.ReadLine());
Console.WriteLine("Jedinična vrijednost:  ");
int rezultod = dvoznamenkastibr % 10;
Console.WriteLine(rezultod);
//zadatak drugacije poslozen