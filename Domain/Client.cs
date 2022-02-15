using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Automated_Car_Wash.Domain
{
    public class Client
    {
        public int ClientId { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}
