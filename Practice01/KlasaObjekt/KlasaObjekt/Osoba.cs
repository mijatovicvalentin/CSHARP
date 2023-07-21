
namespace KlasaObjekt
{
    //klasa je opisnik objekta (klasa opisuje objekt)
    internal class Osoba
    {
        //    {
        //        //ovako se ne smiju deklarirati svojstva u klasi
        //        public string ime;
        //        internal string prezime;
        //         int godine;
        //    }
        //}


        //ZATO ŠTO NIJE ZADOVOLJEN OOP PRINCIN UČAHURIVANJA

        //ZADNJA VRSTA METODA takozvani "konstruktor"
        //poziva se u trenutku instanciranja novog objekta (ključna riječ new)
        //ona nije obavezna. ako nije definirana poziva se konstruktor nadklase
        //naziv konstruktora mora biti indentican nazivu klase
        public Osoba()
        {
            Console.WriteLine("Konstruktor klase osoba");
        }
        public Osoba(string ime)
        {
            Console.WriteLine(ime);
        }
    }
}