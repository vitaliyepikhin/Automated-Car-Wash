using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Automated_Car_Wash.Controllers
{
    [ApiController]
    [Route("/Operator")]
    public class OperatorController : ControllerBase
    {

        [HttpGet("DistSlezhka")]
        public string DistSlezhka(string str)
        {
            return str; //"Метод слежки за процессом мойки"
        }

        [HttpGet("PriemZakaza")]
        public string PriemZakaza(string str)
        {
            return str;// "Метод приёма заказа"
        }

        [HttpPost("ZapuskMoiki")]
        public string ZapuskMoiki(string str)
        {
            return str;// "Метод запуска робот-мойки"
        }

        [HttpGet("PriemOplata")]
        public string PriemOplata(string str)
        {
            return str;// "Метод приема оплаты"
        }

        [HttpPut("Create")]
        public string Create(string str)
        {
            return str;
        }

        [HttpGet("Read")]
        public string Read(string str)
        {
            return str;
        }

        [HttpPatch("Update")]
        public string Update(string str)
        {
            return str;
        }

        [HttpDelete("Delete")]
        public string Delete(string str)
        {
            return str;
        }

    }
}
