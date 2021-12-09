using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Automated_Car_Wash.Controllers
{
    [ApiController]
    [Route("/Client")]
    public class ClientController : ControllerBase
    {

        [HttpGet("DistSlezhka")]
        public string DistSlezhka(string str)
        {
            return str; //"Метод слежки за процессом мойки"
        }

        [HttpGet("ZakazUslug")]
        public string ZakazUslug(string str)
        {
            return str;// "Метод заказа услуг"
        }

        [HttpPost("OcenkaKachestva")]
        public string OcenkaKachestva(string str)
        {
            return str;// "Метод оценки качества"
        }

        [HttpPost("Oplata")]
        public string Oplata(string str)
        {
            return str;// "Метод оплаты мойки"
        }

        [HttpPut]
        public string Create(string str)
        {
            return str;
        }

        [HttpGet]
        public string Read(string str)
        {
            return str;
        }

        [HttpPatch]
        public string Update(string str)
        {
            return str;
        }

        [HttpDelete]
        public string Delete(string str)
        {
            return str;
        }

    }
}
