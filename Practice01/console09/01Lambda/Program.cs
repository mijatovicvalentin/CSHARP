



using _01Lambda;

int KlasicnaMetoda(int b)
{
    return b * b;
}


Console.WriteLine(KlasicnaMetoda(5));



var kvadrat = (int b) => b * b;

Console.WriteLine(kvadrat(5));

//lambda statement
var algoritam = (int x, int y) =>
{
    var t = x++ + --y;
    return x + y - t;
};

Console.WriteLine(algoritam(1, 2));



int[] brojevi = { 2, 3, 4, 3, 2, 3,3, 4 };
//prebrojite koliko ima brojeva s vrijednošču 3 u nizu 4

int ukupno = 0;
foreach(int k in brojevi)
{
    if(k == 3)
    {
        ukupno++;   
    }
}
Console.WriteLine(ukupno);

Console.WriteLine(brojevi.Count(b => b>3)); //bitno



for(int i = 0; i < brojevi.Length; i++)
{
    Console.WriteLine(brojevi[i]);
}

Console.WriteLine("-----------------");
foreach(int k in brojevi)
{
    Console.WriteLine(k);
}

Console.WriteLine(".................");

Array.ForEach(brojevi, Console.WriteLine); //bitno

Console.WriteLine("__________________");


//ispsiati svaki broj uvećan za 1

Array.ForEach(brojevi, b => //bitno
{


    Console.WriteLine(b + 1);

});


Console.WriteLine("_________________");
//deklarirajte listu sa sljedecim elementima 2,3,4,5,4



var lista = new List<int>() { 2, 3, 4, 5, 4 };

lista.ForEach(Console.WriteLine);


var smjerovi = new List<Smjer>()
{
    new () {Naziv = "Prvi", sifra=1},
    new () {Naziv = "Drugi", sifra=2}
};

smjerovi.ForEach(Console.WriteLine);

smjerovi.ForEach(s =>
{
    int b = s.sifra + new Random().Next();
    Console.WriteLine(s.Naziv + " " + b);
});


string s = "Edunova";

Console.WriteLine(s?.Replace("a", "ica"));