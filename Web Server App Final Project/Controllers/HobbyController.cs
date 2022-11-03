using Microsoft.AspNetCore.Mvc;

namespace Web_Server_App_Final_Project.Controllers
{
    public class HobbyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
