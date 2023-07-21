

using KlasaObjekt;

string ime = "Pero";
string prezime = "perić";
int godine = 24;

ime = "marija";

string ime1 = "marija";

//MUST DO!!!
//objekt je instanca/pojavnost klase
//osoba je naziv klase (tip podatka)
//o je istanca klase, o je objekt, o je varijabla
//new je ključna riječ koja poziva posebnu metodu: konstruktor
Osoba o =  new Osoba();


o = new Osoba("pero");

//eksplicitni način deklariranja varijabli
Osoba natjecatelj = new Osoba();


//implicitni nacin deklariranja varijabli
var prijavitelj = new Osoba("Marija"); //desna strana određuje tip podatka varijable
var i = 1; 

//ZO1 DRUGI DIO RJEŠENJA
Dokument d = new Dokument();
d = new Dokument(12);
var broj = new Dokument(15);
d = new Dokument("Supra");

//drugi nacin sa nizom
Dokument[] dokumenti = new Dokument[4];
dokumenti[0] = new Dokument();
dokumenti[1] = new Dokument(12);
dokumenti[2] = new Dokument(15);
dokumenti[3] = new Dokument("Supra");


smjer smjer = new smjer("petak",3);




Grupa grupa;
for(int u = 0; u < 128; u++)
{
    grupa = new Grupa();
}

