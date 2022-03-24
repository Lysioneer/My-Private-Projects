using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListingToDos.Models
{
    public class Assignee
    {
        [Key]
        public long Key { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }

        public List<ToDo> AssigneesToDos { get; set; }
    }
}
