using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Automated_Car_Wash.Domain
{
    public class Video
    {
        public int VideoId { get; set; }

        public DateTime VideoDate{ get; set; }

        public int BoxId { get; set; }

    }
}

