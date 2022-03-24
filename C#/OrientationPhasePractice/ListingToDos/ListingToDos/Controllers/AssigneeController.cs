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
    public class AssigneeController : Controller
    {
        private AssigneeService AssigneeService { get; }
        public AssigneeController(AssigneeService assigneeService)
        {
            AssigneeService = assigneeService;
        }
        [HttpGet("/ListAssignees")]
        public IActionResult ListAssignees()
        {
            ViewModel viewModel = new();
            var assignees = AssigneeService.Find();
            viewModel.AllAssignees = assignees;
            return View(viewModel);
        }
        [HttpGet("/AddAssignee")]
        public IActionResult AddAssignee()
        {
            return View();
        }
        [HttpPost("/AddedAssignee")]
        public IActionResult AddedAssignee(Assignee assignee)
        {
            AssigneeService.AddedAssignee(assignee);
            return RedirectToAction("ListAssignees");
        }
        [HttpGet("/{id}/deleteAssignee")]
        public IActionResult DeleteAssignee([FromRoute] long id)
        {
            AssigneeService.DeleteAssignee(id);
            return RedirectToAction("ListAssignees");
        }
        [HttpGet("/{id}/editAssignee")]
        public IActionResult EditAssignee([FromRoute] long id)
        {
            var assignee = AssigneeService.Find(id);
            ViewModel viewModel = new();
            viewModel.Assignee = assignee;
            return View(viewModel);
        }
        [HttpPost("/EditedAssignee")]
        public IActionResult EditedAssignee(string name, string email, long key)
        {
            AssigneeService.Edit(name, email, key);
            return RedirectToAction("ListAssignees");
        }
    }
}
