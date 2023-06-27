using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public DateTime? Deadline { get; set; }
        public int? NoteId { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime? DataCreate { get; set; }
        public int? ProjectId { get; set; }

        public virtual Note Note { get; set; }
        public virtual Project Project { get; set; }
    }
}
