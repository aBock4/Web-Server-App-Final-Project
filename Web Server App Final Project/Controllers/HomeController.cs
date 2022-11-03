using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_Server_App_Final_Project.Models;

namespace Web_Server_App_Final_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}