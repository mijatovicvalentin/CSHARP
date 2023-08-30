using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace HelloWorld.Controllers
{

    [ApiController]
    [Route("[Controller]")]


    public class HelloWorldController : ControllerBase
    {

        [HttpGet]
        public string Hello()
        {
            return "HelloWorld";
        }
       
        [HttpGet]
        [Route("Pozdrav")]
        public string DrugaMetoda()
        {
            return "Pozdrav Svijetu";
        }

        [HttpGet]
        [Route("PozdravParametar")]


        public string DrugaMetoda(string s ) 
        {

            return "Hello " + s;
         
        }

        [HttpGet]
        [Route("PozdravViseParametara")]


        public string DrugaMetoda(string s="", int i=0)
        {

            return "Hello " + s + " " + i;

        }

        //Kreirajte rutu /HelloWorld/zad1 koja en prima parametre i vraćba Vaše ime
        [HttpGet]
        [Route("Zad1")]
        public string helloWorld()
        {

            return "Valentin Mijatović";

        }


        //Kreirajte rutu /HelloWorld2/zad2 koja prima dva broja i vraća njihov zbroj
        [HttpGet]
        [Route("Zad2")]
        public int helloWorld2(int i=0, int b=0) 
        {
            return i + b;
        }

        //Kreirajte rutu /HelloWorld3/zad3 koja prima parametar brojPonavljanja
        //ruta vraca niz znakova "Osijek koji ima onoliko elemenata koliko smo
        //primili brojPonavljanja

        [HttpGet]
        [Route("Zad3")]
        public string HelloWorld3(int brojPonavljanja, string Osijek)
        {
            return brojPonavljanja + Osijek;
        }


        [HttpGet]
        [Route("{sifra:int}")]


        public string PozdravRuta(int sifra)
        {

            return "Hello " + sifra;

        }



        [HttpGet]
        [Route("{sifra:int}/{kategorija}")]


        public string PozdravRuta2(int sifra, string kategorija)
        {

            return "Hello " + sifra + " " + kategorija;

        }


        //--------------------------------------------------------------

        [HttpPost]
        public string DodavanjeNovog(string ime)
        {
            return "Dodao " + ime;
        }



        [HttpPut]
        public string promjena (int sifra, string naziv)
        {
            return "na sifri " + sifra + " postavljam naziv " + naziv;
        }



        [HttpDelete]
        public bool obrisao(int sifra)
        {

            return true;

        }


        ///////////////////////////////////
        [HttpGet]
        [Route("matrica")]

        public String Matrica(int x, int y)
        {
            var m = new int[x, y];

            return new JsonResult(JsonConvert.SerializeObject(m);      
        }


    }
}
