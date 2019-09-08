+++using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wholesale.Models
{
    public class User
    {
        public int userID { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public bool? activeUser { get; set; }
        public UserGroup UserGroup { get; set; }
        public ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
