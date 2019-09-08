using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wholesale.Models
{
    public class OrderDetail
    {
        public int orderDetailID { get; set; }
        public int? productID { get; set; }
        public int? orderID { get; set; }
        public int orderCount { get; set; }
        public decimal productPrice { get; set; }
        public string sendingWay { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
