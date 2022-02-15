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
        public Operator Create(Operator operator)
        {
            Storage.OperatorStorage.Create(operator);
            return Storage.OperatorStorage.Read(operator.Id);
        }

        [HttpGet("Read")]
        public Operator Read(int Id)
        {
            return Storage.OperatorStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Operator Update(int Id, Operator newOperator)
        {
            return Storage.OperatorStorage.Update(Id, newOperator);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.OperatorStorage.Delete(Id);
        }
    }
}

