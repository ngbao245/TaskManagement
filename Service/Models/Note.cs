using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Note
    {
        public Note()
        {
            Tasks = new HashSet<Task>();
        }

        public int NoteId { get; set; }
        public string Image { get; set; }
        public string File { get; set; }
        public string Text { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
