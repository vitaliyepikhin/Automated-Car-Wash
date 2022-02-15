using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Automated_Car_Wash.Domain
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public int ClientId { get; set; }

        public DateTime PaymentDate { get; set; }

    }
}

