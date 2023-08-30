﻿using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{

    [ApiController]
    [Route("Controller")]
    public class SmjerController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {

            var lista = new List<Smjer>()
            {
                new (){Naziv="Prvi"},
                new (){Naziv="Drugi"}


            };

            return new JsonResult(lista);

        }

        [HttpPost]
        public IActionResult Post(Smjer smjer)
        {
            return Created("/api&v1/smjer", smjer);
        }


        [HttpPut]
        [Route("{sifra:int}")]
        public IActionResult Put(int sifra, string smjer)
        {

            return StatusCode(StatusCodes.Status200OK, smjer);

        }


        [HttpDelete]
        [Route("{sifra:int}")]
        public IActionResult Delete(int sifra)
        {
            return StatusCode(StatusCodes.Status200OK, "{\"obrisano\"),", sifra);
        }

        private IActionResult StatusCode(int status200OK, string v, int sifra)
        {
            throw new NotImplementedException();
        }
    }
}
