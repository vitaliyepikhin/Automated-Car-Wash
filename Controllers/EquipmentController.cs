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
            return Storage.EquipmentStorage.Read(equipment.EquipmentId);
        }

        [HttpGet("Read")]
        public Equipment Read(int EquipmentId)
        {
            return Storage.EquipmentStorage.Read(EquipmentId);
        }

        [HttpPatch("Update")]
        public Equipment Update(int EquipmentId, Equipment newEquipment)
        {
            return Storage.EquipmentStorage.Update(EquipmentId, newEquipment);
        }

        [HttpDelete("Delete")]
        public bool Delete(int EquipmentId)
        {
            return Storage.EquipmentStorage.Delete(EquipmentId);
        }
    }
}
