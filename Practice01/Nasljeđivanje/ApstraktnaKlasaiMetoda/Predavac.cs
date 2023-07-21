using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApstraktnaKlasaiMetoda
{
    internal class Predavac : Osoba
    {

        public int godine { get; set; }
        public override void Pozdrav()
        {
            Console.WriteLine(godine>24 ? "Dobar dan gospođo/ine " : "Dobar dan mladiću"); //isto umjesto if else stavi se :
        }
    }
}
