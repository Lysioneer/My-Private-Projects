using ListingToDos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingToDos.Services
{
    public class ToDoService
    {
        private ApplicationDbContext DbContext { get; }
        private AssigneeService AssigneeService { get; }
        public ToDoService(ApplicationDbContext dbContext, AssigneeService assigneeService)
        {
            DbContext = dbContext;
            AssigneeService = assigneeService;
        }

        public List<ToDo> ListToDos()
        {
            return DbContext.ToDos.ToList();
        }
        public List<ToDo> ListUndone()
        {
            return DbContext.ToDos.Where(p => p.IsDone == false).ToList();
        }
        public void AddToDo(string title, string description, bool isUrgent, long assigneeKey)
        {
            var assignee = AssigneeService.FindSpec(assigneeKey);

            ToDo todo = new();
            todo.Title = title;
            todo.Description = description;
            todo.IsUrgent = isUrgent;
            todo.Assignee = assignee;
            todo.AssigneeId = assigneeKey;
            DbContext.ToDos.Add(todo);
            DbContext.SaveChanges();
        }
        public void RemoveToDo(long id)
        {
            DbContext.ToDos.Remove(DbContext.ToDos.Where(p => p.Key == id).FirstOrDefault());
            DbContext.SaveChanges();
        }
        public ToDo Find(long id)
        {
            return DbContext.ToDos.Where(p => p.Key == id).FirstOrDefault();
        }
        public void Edit(ToDo todo, long assigneeKey)
        {
            var assignee = DbContext.Assignees.Where(p => p.Key == assigneeKey).FirstOrDefault();

            DbContext.ToDos.Remove(DbContext.ToDos.Where(p => p.Key == todo.Key).FirstOrDefault());
            todo.Assignee = assignee;
            todo.AssigneeId = assigneeKey;
            DbContext.ToDos.Add(todo);
            DbContext.SaveChanges();
        }
        public List<ToDo> Search(string searchInput)
        {
            var todos = DbContext.ToDos.Where(p => p.Title.Contains(searchInput) || 
            p.Description.Contains(searchInput)).ToList();
            return todos;
        }
    }
}
