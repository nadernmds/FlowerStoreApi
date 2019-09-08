using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wholesale.Models
{
    public class Condition
    {
        public int conditionID { get; set; }
        public string description { get; set; }
        public ICollection<Order> Orders = new HashSet<Order>();
    }
}
