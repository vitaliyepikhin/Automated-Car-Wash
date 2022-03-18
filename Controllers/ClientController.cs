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

        [HttpPut("Create")]
        public Client Create(Client client)
        {
            Storage.ClientStorage.Create(client);
            return Storage.ClientStorage.Read(client.ClientId);
        }

        [HttpGet("Read")]
        public Client Read(int ClientId)
        {
            return Storage.ClientStorage.Read(ClientId);
        }

        [HttpPatch("Update")]
        public Client Update(int ClientId, Client newClient)
        {
            return Storage.ClientStorage.Update(ClientId, newClient);
        }

        [HttpDelete("Delete")]
        public bool Delete(int ClientId)
        {
            return Storage.ClientStorage.Delete(ClientId);
        }
    }
}

