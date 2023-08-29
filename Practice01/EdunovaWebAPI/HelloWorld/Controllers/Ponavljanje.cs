using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.Runtime.CompilerServices;

namespace HelloWorld.Controllers
{


    [ApiController]
    [Route("[Controller]")]

    public class Ponavljanje : ControllerBase 

    {

        [HttpGet]
        [Route("Ponavljanje")]
        public string ForPetlja( int a , string godište    )
        {
          
           return "Vaše Godište : " +  a + godište;

        }

        [HttpGet]
        [Route("Ponavljanje 2")]
        public int Ponavljanje2(int a, int b, int c, int d, int e)
        {


            return a / b + c * (d + e);


        }

    }
}
