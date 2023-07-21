

//apstraktno znaci da ne mozes imati instancu

using ApstraktnaKlasaiMetoda;

//Osoba osoba = new Osoba();  //mora se  nasljediti jer je apstraktna

Polaznik polaznik = new Polaznik
{
    ime = "Pero",
    spol = "Muško"

};

Predavac polaznik1 = new Predavac
{
    ime = "Mario",
    godine = 24

};

void ispis(Osoba osoba)
{
    osoba.Pozdrav();
}
ispis(polaznik);
ispis(polaznik1);