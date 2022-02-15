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
            return Storage.RatingStorage.Read(rating.RatingId);
        }

        [HttpGet("Read")]
        public Rating Read(int RatingId)
        {
            return Storage.RatingStorage.Read(RatingId);
        }

        [HttpPatch("Update")]
        public Rating Update(int RatingId, Rating newRating)
        {
            return Storage.RatingStorage.Update(RatingId, newRating);
        }

        [HttpDelete("Delete")]
        public bool Delete(int RatingId)
        {
            return Storage.RatingStorage.Delete(RatingId);
        }
    }
}

