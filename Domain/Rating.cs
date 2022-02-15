using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Automated_Car_Wash.Domain
{
    public class Rating
    {
        public int RatingId { get; set; }

        public int ClientId { get; set; }

        public DateTime RatingDate { get; set; }

        public string Rating { get; set; }

    }
}

