using Microsoft.AspNetCore.Mvc;
using Web_Server_App_Final_Project.Models;

namespace Web_Server_App_Final_Project.Controllers
{
    public class HobbiesController : Controller
    {
        private HobbyContext context { get; set; }
        public HobbiesController(HobbyContext ctx)
        {
            context = ctx;
        }
        public IActionResult OurData()
        {
            var cars = context.Cars?
                .OrderBy(m => m.Year)
                .ToList();
            return View(cars);
        }
    }
}