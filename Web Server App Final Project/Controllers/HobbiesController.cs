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
            var tables = new HobbyViewModel
            {
                Cars = context.Cars?.OrderBy(m => m.Year).ToList(),
                Games = context.Games?.OrderBy(m => m.Year).ToList(),
                Trumpets = context.Trumpet?.OrderBy(m => m.Year).ToList()

            };
            return View(tables);
        }
    }
}