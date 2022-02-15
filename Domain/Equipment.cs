using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Automated_Car_Wash.Domain
{
    public class Equipment
    {
        public int EquipmentId { get; set; }

        public string NomerBox { get; set; }

        public string Name { get; set; }


    }
}

