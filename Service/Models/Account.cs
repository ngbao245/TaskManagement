using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Account
    {
        public Account()
        {
            Users = new HashSet<User>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
