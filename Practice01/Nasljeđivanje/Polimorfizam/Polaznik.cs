using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    internal class Polaznik : Osoba
    {
        public override string pozdravi()
        {
            return "Dobar dan polazniče  " + ime;
        }
    }
}
