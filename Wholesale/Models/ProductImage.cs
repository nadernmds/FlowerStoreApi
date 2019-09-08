using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wholesale.Models
{
    public class ProductImage
    {
        public int productImageID { get; set; }
        public int? productID { get; set; }
        public Product Product { get; set; }
    }
}
