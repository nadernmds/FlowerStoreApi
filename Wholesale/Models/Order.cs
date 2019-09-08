using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wholesale.Models
{
    public class Order
    {
        public int orderID { get; set; }
        public decimal sendingPrice { get; set; }
        public System.DateTime data { get; set; }
        public int conditionID { get; set; }
        public int? userID { get; set; }
        public int? addressID { get; set; }
        public User User { get; set; }
        public Condition Condition { get; set; }
        public ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
        public ICollection<OrderDetail> OrderDetails { get; set; } = new HashSet<OrderDetail>();

    }
}
