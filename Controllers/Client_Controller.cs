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
    public class Client_Controller : ControllerBase
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

        [HttpGet("OcenkaKachestva")]
        public string OcenkaKachestva(string str)
        {
            return str;// "Метод оценки качества"
        }

        [HttpGet("Oplata")]
        public string Oplata(string str)
        {
            return str;// "Метод оплаты мойки"
        }

    }
}
