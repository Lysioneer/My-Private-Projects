using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingToDos.Models
{
    public class ViewModel
    {
        public List<ToDo> AllToDos { get; set; }
        public ToDo ToDo { get; set; }
        public List<Assignee> AllAssignees { get; set; }
        public Assignee Assignee { get; set; }
    }
}
