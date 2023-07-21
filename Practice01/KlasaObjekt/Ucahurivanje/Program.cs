

using System.Xml;
using Ucahurivanje;

osoba Osoba = new osoba();
Osoba.setime("Pero");
Osoba.prezime=("Perić"); //ovako cemo u nastavku koristiti
Console.WriteLine("{0}{1}",Osoba.prezime, Osoba.getime());

Smjer smjer = new Smjer();
smjer.sifra = 1;
smjer.nazIv = "Web programiranje";
smjer.trajanje = 250;
//i ostala svojstva

//brza sintaksa
smjer = new Smjer()
{
    sifra = 1,
    nazIv = "Web Programiranje"
    // i ostale vrijednosti
};

Zupanija zupanija = new Zupanija
{
    naziv = "Osječko Baranjska",
    Župan = "Anušić"
};

Grad grad = new Grad
{
    naziv = "Osijek",
    zupanija = zupanija
};

//ispis svojstava kada jedna klasa sadrzi instancu druge klase
Console.WriteLine("Grad je  {0}, Županija je {1}", grad.naziv,grad.zupanija.naziv );