using Automated_Car_Wash.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Automated_Car_Wash.Repository
{
    public class OrderStorage
    {
        private readonly Dictionary<int, Order> _Orders = new();

        public Order Create(Order order)
        {

            _Orders.Add(order.OrderId, order);
            return order;

        }

        public Order Read(int OrderId)
        {
            return _Orders[OrderId];
        }

        public Order Update(int OrderId, Order newOrder)
        {
            _Orders[OrderId] = newOrder;
            return _Orders[OrderId];
        }

        public bool Delete(int OrderId)
        {
            return _Orders.Remove(OrderId);
        }
    }
}