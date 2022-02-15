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
    [Route("/Equipment")]
    public class EquipmentController : ControllerBase
    {

        [HttpPut("Create")]
        public Equipment Create(Equipment equipment)
        {
            Storage.EquipmentStorage.Create(equipment);
            return Storage.EquipmentStorage.Read(equipment.Id);
        }

        [HttpGet("Read")]
        public Equipment Read(int Id)
        {
            return Storage.EquipmentStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Equipment Update(int Id, Equipment newEquipment)
        {
            return Storage.EquipmentStorage.Update(Id, newEquipment);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.EquipmentStorage.Delete(Id);
        }
    }
}
