using ASPPractise.Models;
using ASPPractise.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPPractise.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        CalcService CalcService { get; set; }
        public HomeController(CalcService calcService)
        {
            CalcService = calcService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("interesting")]
        public IActionResult Interesting()
        {
            return View();
        }
        [HttpGet("calculator")]
        public IActionResult Calculator()
        {
            return View();
        }
        [HttpPost("calculating")]
        public IActionResult Calculating(int firstNumber, string value, int secondNumber)
        {
            Number number = new();
            number.result = CalcService.Operation(firstNumber, value, secondNumber);
            return View("Result", number);
        }
    }
}
