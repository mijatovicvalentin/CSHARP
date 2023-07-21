


using Nasljeđivanje;

Osoba osoba = new Osoba
{
    sifra = 1,
    ime = "Pero",
    prezime = "Peric"
};

Console.WriteLine(osoba);


Osoba DrugaOsoba = new Osoba
{
    sifra = 1,
    ime = "Marina",
    prezime = "Marić"
};

Console.WriteLine(osoba.Equals(DrugaOsoba));

Polaznik polaznik = new Polaznik
{
    sifra = 1,
    ime = "Marko",
    prezime = "Kat",
    BrojUgovora = "2023/56"
};
Console.WriteLine(polaznik);



Predavac predavac = new Predavac
{
    sifra = 1,
    ime = "Rita",
    prezime = "Man",
    iban = "HR1920947581"


};

Console.WriteLine(predavac);