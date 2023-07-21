
using Polimorfizam;

Osoba[] osobe = new Osoba[3];

osobe[0] = new Polaznik { ime = "Pero" };
osobe[1] = new Polaznik { ime = "Kata" };
osobe[2] = new Polaznik { ime = "Mata" };


void pozdraviSve(Osoba[]osoba)
{
foreach (Osoba osobe in osobe)
    {
        //ovo je izvedba polimorfizma
        Console.WriteLine(osobe.pozdravi());
    }
}

pozdraviSve(osobe);
// tri klase osoba, predavac i polaznik us pozornica za polimorfizam