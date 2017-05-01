using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.BL2
{
    public class OrderRepository
    {

        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2017, 4, 26, 16, 0, 0, new TimeSpan(0));
            }


            return order;
        }

        public bool Save() => true;
    }
}
