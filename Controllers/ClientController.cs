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

        [HttpPut("Create")]
        public Client Create(Client client)
        {
            Storage.ClientStorage.Create(client);
            return Storage.ClientStorage.Read(client.Id);
        }

        [HttpGet("Read")]
        public Client Read(int Id)
        {
            return Storage.ClientStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Client Update(int Id, Client newClient)
        {
            return Storage.ClientStorage.Update(Id, newClient);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.ClientStorage.Delete(Id);
        }
    }
}

