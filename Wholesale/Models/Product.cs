using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wholesale.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public int existingCount { get; set; }
        public decimal price { get; set; }
        public bool? exisitState { get; set; }
        public bool? activeProduct { get; set; }
        public string description { get; set; }
        public int? productCategoryID { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; } = new HashSet<OrderDetail>();
        public ICollection<ProductImage> ProductImages { get; set; } = new HashSet<ProductImage>();
    }
}
