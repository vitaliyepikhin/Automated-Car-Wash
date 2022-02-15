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
    [Route("/Payment")]
    public class PaymentController : ControllerBase
    {

        [HttpPut("Create")]
        public Payment Create(Payment payment)
        {
            Storage.PaymentStorage.Create(payment);
            return Storage.PaymentStorage.Read(payment.PaymentId);
        }

        [HttpGet("Read")]
        public Payment Read(int PaymentId)
        {
            return Storage.PaymentStorage.Read(PaymentId);
        }

        [HttpPatch("Update")]
        public Payment Update(int PaymentId, Payment newPayment)
        {
            return Storage.PaymentStorage.Update(PaymentId, newPayment);
        }

        [HttpDelete("Delete")]
        public bool Delete(int PaymentId)
        {
            return Storage.PaymentStorage.Delete(PaymentId);
        }
    }
}
