﻿using System;
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
    [Route("/Service")]
    public class ServiceController : ControllerBase
    {

        [HttpPut("Create")]
        public Service Create(Service service)
        {
            Storage.ServiceStorage.Create(service);
            return Storage.ServiceStorage.Read(service.Id);
        }

        [HttpGet("Read")]
        public Service Read(int Id)
        {
            return Storage.ServiceStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Service Update(int Id, Service newService)
        {
            return Storage.ServiceStorage.Update(Id, newService);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.ServiceStorage.Delete(Id);
        }
    }
}
