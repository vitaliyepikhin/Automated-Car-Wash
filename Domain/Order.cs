using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Automated_Car_Wash.Domain
{
    public class Order
    {
        public int OrderId { get; set; }

        public decimal Price { get; set; }

        public DateTime OrderDate{ get; set; }

        public int RatingId { get; set; }

        public int PaymentId { get; set; }

        public int OperatorId { get; set; }

        public int BoxId { get; set; }

        public int ServiceId { get; set; }
    }
}

