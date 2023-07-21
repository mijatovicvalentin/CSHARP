using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApstraktnaKlasaiMetoda
{
    internal class Polaznik : Osoba
    {
        public string BrojUgovora { get; set; }

        public string spol { get; set; }

        public override void Pozdrav()
        {
            Console.WriteLine(spol.Equals("Ženski") ? "Dobar dan gospođo" : "Dobar dan gospodine"); //ovo je kao if i else ali u cw 
        }
    }
}
