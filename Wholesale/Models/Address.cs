using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wholesale.Models
{
    public class Address
    {
        public int addressID { get; set; }
        public string addressDetail { get; set; }
        public string postalCode { get; set; }
        public int? userID { get; set; }
        public User User { get; set; }
        public Order Order { get; set; }
    }
}
