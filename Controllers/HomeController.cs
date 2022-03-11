using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyTestDeploy.Data;
using MyTestDeploy.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyTestDeploy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentContext _studentContext;

        public HomeController(ILogger<HomeController> logger, StudentContext studentContext)
        {
            _logger = logger;
            _studentContext = studentContext;
        }

        public IActionResult Index()
        {
            return View(_studentContext.Students.ToList());
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
