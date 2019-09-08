using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wholesale.Models
{
    public class UserGroup
    {
        public int usergroupID { get; set; }
        public string groupName { get; set; }
        public ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
