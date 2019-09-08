using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wholesale.Models
{
    public class ProductCategory
    {

        public int productCategoryID { get; set; }
        public string categoryName { get; set; }
        public ICollection<Product> Products { get; set; }= new HashSet<Product>();

    }
   
}
