using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje
{

    //svaka klasa nasljeđuje objext htjela ona ili ne 
    internal class Osoba : Object
    {


        int brojac;
        protected bool uvijet;
        private string naziv;
        internal DateTime datum;







            public int sifra { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }


        public Osoba()
        { 
        
        }
        //metoda tostring postoji na klasi object i mi ovdje redefiniramo (override) njezino ponasanje
        public override string ToString()
        {
            return ime +"  " + prezime;
        }
        public override bool Equals(Object?obj)
        {
            Osoba osoba = obj as Osoba;
            return sifra.Equals(osoba.sifra); //base je nadklasa (jedna kalsa moze ansljedtii samo jednu nadklasu)
        }
    } 

}
