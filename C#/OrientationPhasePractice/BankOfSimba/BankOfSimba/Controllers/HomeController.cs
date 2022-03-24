using BankOfSimba.Models;
using BankOfSimba.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        BankService BankService { get; set; }

        [HttpGet("/show")]
        public IActionResult Index()
        {
            BankAccount bankAccount = new("Simba", 2000, "lion");
            return View("Index", bankAccount);
        }
        [HttpGet("/list")]
        public IActionResult ListOfAccounts()
        {
            var accounts = BankService.ListAllAccounts();
            ViewModel viewModel = new();
            viewModel.AllAccounts = accounts;
            return View("ListOfAccounts", viewModel);
        }
    }
}
