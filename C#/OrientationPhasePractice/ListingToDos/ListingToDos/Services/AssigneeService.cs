using ListingToDos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingToDos.Services
{
    public class AssigneeService
    {
        private ApplicationDbContext DbContext { get; }
        public AssigneeService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public List<Assignee> Find()
        {
            return DbContext.Assignees.ToList();
        }
        public void AddedAssignee(Assignee assignee)
        {
            DbContext.Assignees.Add(assignee);
            DbContext.SaveChanges();
        }
        public void DeleteAssignee(long id)
        {
            var assignee = DbContext.Assignees.Where(p => p.Key == id).FirstOrDefault();
            DbContext.Assignees.Remove(assignee);
            DbContext.SaveChanges();
        }
        public Assignee Find(long id)
        {
            return DbContext.Assignees.Where(p => p.Key == id).FirstOrDefault();
        }
        public void Edit(string name, string email, long key)
        {
            var assignee = DbContext.Assignees.Where(p => p.Key == key).FirstOrDefault();
            DbContext.Assignees.Remove(assignee);
            DbContext.SaveChanges();
            assignee.Name = name;
            assignee.Email = email;
            DbContext.Assignees.Add(assignee);
            DbContext.SaveChanges();
        }
        public Assignee FindSpec(long assigneeKey)
        {
            return DbContext.Assignees.Where(p => p.Key == assigneeKey).FirstOrDefault();
        }
    }
}
