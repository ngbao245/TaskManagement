using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class User
    {
        public User()
        {
            Projects = new HashSet<Project>();
        }

        public int UserId { get; set; }
        public string FullName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public int? PhoneNumber { get; set; }
        public DateTime? DateCreate { get; set; }

        public virtual Account UsernameNavigation { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
