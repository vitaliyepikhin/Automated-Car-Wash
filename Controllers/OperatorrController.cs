using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Automated_Car_Wash.Domain;
using Automated_Car_Wash.Repository;

namespace Automated_Car_Wash.Controllers
{
    [ApiController]
    [Route("/Operatorr")]
    public class OperatorrController : ControllerBase
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
        public Operatorr Create(Operatorr operatorr)
        {
            Storage.OperatorrStorage.Create(operatorr);
            return Storage.OperatorrStorage.Read(operatorr.OperatorrId);
        }

        [HttpGet("Read")]
        public Operatorr Read(int OperatorrId)
        {
            return Storage.OperatorrStorage.Read(OperatorrId);
        }

        [HttpPatch("Update")]
        public Operatorr Update(int OperatorrId, Operatorr newOperatorr)
        {
            return Storage.OperatorrStorage.Update(OperatorrId, newOperatorr);
        }

        [HttpDelete("Delete")]
        public bool Delete(int OperatorrId)
        {
            return Storage.OperatorrStorage.Delete(OperatorrId);
        }
    }
}

