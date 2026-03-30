using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_1.Controllers
{
    public class Assignment12Controller : Controller
    {
        public IActionResult Index()
        {
            ViewData["Age"] = 20;
            return View();
        }
    }
}
