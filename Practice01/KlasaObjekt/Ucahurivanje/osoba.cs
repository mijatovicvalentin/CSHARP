using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucahurivanje
{
    internal class osoba
    {
        //UCAHURIVANJE - klasa ce sakriti svoja svojstva
        private string ime;

        //klasa ce ucniti svojstvo dostupnim tkz get i set metoda
        public void setime(string ime)
        {
            this.ime = ime; 
        }

        public string getime()
        { 
         return this.ime;
        }


        public string prezime { get; set; }


        public osoba() 
        
        {
            Console.WriteLine();
        }
    }
}
