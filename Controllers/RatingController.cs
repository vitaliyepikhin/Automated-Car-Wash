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
    [Route("/Rating")]
    public class RatingController : ControllerBase
    {

        [HttpPut("Create")]
        public Rating Create(Rating rating)
        {
            Storage.RatingStorage.Create(rating);
            return Storage.RatingStorage.Read(rating.Id);
        }

        [HttpGet("Read")]
        public Rating Read(int Id)
        {
            return Storage.RatingStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Rating Update(int Id, Rating newRating)
        {
            return Storage.RatingStorage.Update(Id, newRating);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.RatingStorage.Delete(Id);
        }
    }
}

