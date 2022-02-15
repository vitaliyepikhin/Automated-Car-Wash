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
    [Route("/Box")]
    public class BoxController : ControllerBase
    {

        [HttpPut("Create")]
        public Box Create(Box box)
        {
            Storage.BoxStorage.Create(box);
            return Storage.BoxStorage.Read(box.BoxId);
        }

        [HttpGet("Read")]
        public Box Read(int BoxId)
        {
            return Storage.BoxStorage.Read(BoxId);
        }

        [HttpPatch("Update")]
        public Box Update(int BoxId, Box newBox)
        {
            return Storage.BoxStorage.Update(BoxId, newBox);
        }

        [HttpDelete("Delete")]
        public bool Delete(int BoxId)
        {
            return Storage.BoxStorage.Delete(BoxId);
        }
    }
}

