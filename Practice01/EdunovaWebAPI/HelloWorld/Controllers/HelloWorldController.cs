using Microsoft.AspNetCore.Mvc;
using System.Text;

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
        [Route("PozdravViseParametar")]


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
        [Route("Zad 2")]
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

    }
}
