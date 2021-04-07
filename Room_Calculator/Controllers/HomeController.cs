using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Room_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Room_Calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //this handles the view
        public IActionResult Index()
        {
            return View();
        }
        //this overloads to handle post info
        [HttpPost]
        public IActionResult Index(Room room)
        {
            return RedirectToAction("Result", room);
        }
        public IActionResult Result(Room r)
        {
            return View(r);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
