using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApstraktnaKlasaiMetoda
{
    internal abstract class Osoba
    {
        //apstraktna metoda
        public abstract void Pozdrav();//apstraktna metoda nema tijelo (abstract)
     
        public int sifra { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
    }
}
