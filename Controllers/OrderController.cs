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
    [Route("/Order")]
    public class OrderController : ControllerBase
    {

        [HttpPut("Create")]
        public Order Create(Order order)
        {
            Storage.OrderStorage.Create(order);
            return Storage.OrderStorage.Read(order.OrderId);
        }

        [HttpGet("Read")]
        public Order Read(int OrderId)
        {
            return Storage.OrderStorage.Read(OrderId);
        }

        [HttpPatch("Update")]
        public Order Update(int OrderId, Order newOrder)
        {
            return Storage.OrderStorage.Update(OrderId, newOrder);
        }

        [HttpDelete("Delete")]
        public bool Delete(int OrderId)
        {
            return Storage.OrderStorage.Delete(OrderId);
        }
    }
}

