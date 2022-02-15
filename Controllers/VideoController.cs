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
    [Route("/Video")]
    public class VideoController : ControllerBase
    {

   

        [HttpPut("Create")]
        public Video Create(Video video)
        {
            Storage.VideoStorage.Create(video);
            return Storage.VideoStorage.Read(video.Id);
        }

        [HttpGet("Read")]
        public Video Read(int Id)
        {
            return Storage.VideoStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Video Update(int Id, Video newVideo)
        {
            return Storage.VideoStorage.Update(Id, newVideo);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.VideoStorage.Delete(Id);
        }
    }
}
