using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    internal class Prodavac : Osoba
    {
        public override string pozdravi()
        {
            return "Dobar dan predavaču " + ime;
        }
    }
}
