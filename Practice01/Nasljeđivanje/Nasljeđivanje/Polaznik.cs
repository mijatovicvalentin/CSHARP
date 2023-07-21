using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje
{
    internal class Polaznik : Osoba
    {
        public string BrojUgovora { get; set; }
        public override string ToString()
        {
            //vidimo iz nadklase protected, internal i private nacine pristupa
            //base.uvjet = true;
            return base.ToString() + " " + BrojUgovora;
        }
    }
}
