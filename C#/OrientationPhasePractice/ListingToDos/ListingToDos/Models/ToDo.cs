using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListingToDos.Models
{
    public class ToDo
    {
        [Key]
        public long Key { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }

        public Assignee Assignee { get; set; }
        public long AssigneeId { get; set; }
    }
}
