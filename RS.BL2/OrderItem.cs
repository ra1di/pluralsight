using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.BL2
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId) => OrderItemId = orderItemId;

        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }

        public decimal? PurchasePrice { get; set; }

        public OrderItem Retrieve(int orderItemId) => new OrderItem();
        //{
        //    return new OrderItem();
        //}

        public bool Save() => true;
        //{
        //    return true;
        //}

        public bool Validate()
        {
            var isValid = true;

            if (OrderQuantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice <= 0) isValid = false;


            return isValid;
        }
    }
}
