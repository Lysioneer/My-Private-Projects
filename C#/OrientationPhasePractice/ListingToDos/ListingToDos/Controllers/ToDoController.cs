using ListingToDos.Models;
using ListingToDos.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingToDos.Controllers
{
    [Route("/")]
    public class ToDoController : Controller
    {
        private ToDoService ToDoService { get; }
        private AssigneeService AssigneeService { get; }
        public ToDoController(ToDoService toDoService, AssigneeService assigneeService)
        {
            ToDoService = toDoService;
            AssigneeService = assigneeService;
        }
        public IActionResult List()
        {
            var todos = ToDoService.ListToDos();
            var assignees = AssigneeService.Find();
            ViewModel viewModel = new();
            viewModel.AllToDos = todos;
            viewModel.AllAssignees = assignees;
            return View(viewModel);
        }
        [HttpGet("/ListUndone")]
        public IActionResult ListUndone()
        {
            var todos = ToDoService.ListUndone();
            var assignees = AssigneeService.Find();
            ViewModel viewModel = new();
            viewModel.AllToDos = todos;
            viewModel.AllAssignees = assignees;
            return View("List", viewModel);
        }
        [HttpGet("/Add")]
        public IActionResult Add()
        {
            var assignees = AssigneeService.Find();
            ViewModel viewModel = new();
            viewModel.AllAssignees = assignees;
            return View(viewModel);
        }
        [HttpPost("/AddToDo")]
        public IActionResult AddToDo(string title, string description, bool isUrgent, long assigneeKey)
        {
            ToDoService.AddToDo(title, description, isUrgent, assigneeKey);
            return RedirectToAction("List");
        }
        [HttpGet("/{id}/remove")]
        public IActionResult RemoveToDo([FromRoute]long id)
        {
            ToDoService.RemoveToDo(id);
            return RedirectToAction("List");
        }
        [HttpGet("/{id}/edit")]
        public IActionResult EditToDo([FromRoute]long id)
        {
            var todo = ToDoService.Find(id);
            var assignees = AssigneeService.Find();
            var assignee = AssigneeService.FindSpec(todo.AssigneeId);
            ViewModel viewModel = new();
            viewModel.ToDo = todo;
            viewModel.AllAssignees = assignees;
            viewModel.Assignee = assignee;
            return View(viewModel);
        }
        [HttpPost("/{id}/edited")]
        public IActionResult EditedToDo(ToDo todo, long assigneeKey)
        {
            ToDoService.Edit(todo, assigneeKey);
            return RedirectToAction("List");
        }
        [HttpPost("/search")]
        public IActionResult Search(string searchInput)
        {
            var todos = ToDoService.Search(searchInput);
            var assignees = AssigneeService.Find();
            ViewModel viewModel = new();
            viewModel.AllToDos = todos;
            viewModel.AllAssignees = assignees;
            return View(viewModel);
        }
    }
}
