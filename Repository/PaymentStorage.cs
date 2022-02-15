using Automated_Car_Wash.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Automated_Car_Wash.Repository
{
    public class PaymentStorage
    {
        private readonly Dictionary<int, Payment> _Payments = new();

        public Payment Create(Payment payment)
        {

            _Payments.Add(payment.PaymentId, payment);
            return payment;

        }

        public Payment Read(int PaymentId)
        {
            return _Payments[PaymentId];
        }

        public Payment Update(int PaymentId, Payment newPayment)
        {
            _Payments[PaymentId] = newPayment;
            return _Payments[PaymentId];
        }

        public bool Delete(int PaymentId)
        {
            return _Payments.Remove(PaymentId);
        }
    }
}