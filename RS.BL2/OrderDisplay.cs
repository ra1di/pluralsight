using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.BL2
{
    public class OrderDisplay
    {
        //powiazanie z customer class
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderDisplayItem> orderDisplayItemList { get; set; }
        public int OrderId { get; set; }
        public Address ShippingAddress { get; set; }
    }
}
