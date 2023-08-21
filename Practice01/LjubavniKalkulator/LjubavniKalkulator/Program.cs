Console.WriteLine("------- LJubavni kalkulator -------------");
Console.WriteLine();
Console.Write("Molimo da unesete ime prve osobe: ");
string osoba1 = Console.ReadLine();

Console.WriteLine();

Console.Write("Molimo da unesete ime druge osobe: ");
string osoba2 = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("--------------------------" +
    "" +
    "---------------");


Random rd = new Random();

int Postotak = rd.Next(0, 101);

Console.WriteLine();
Console.WriteLine($"Povezanost {osoba1} i {osoba2} je: {Postotak}%");
Console.WriteLine();

if (Postotak > 90)
{
    Console.WriteLine("Između 90 - 100 posto");
}
else if (Postotak > 70)
{
    Console.WriteLine("Između 70 - 90 posto");
}
else if (Postotak > 50)
{
    Console.WriteLine("Između 50 i 70 posto");
}
else
{
    Console.WriteLine("Između 0 - 50 posto");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("--------- Hvala na sudjelovanju ---------");