using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Project
    {
        public Project()
        {
            Tasks = new HashSet<Task>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime? Deadline { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public int? Uid { get; set; }

        public virtual User UidNavigation { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
