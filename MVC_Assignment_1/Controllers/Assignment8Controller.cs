using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_1.Controllers
{
    public class Assignment8Controller : Controller
    {
        public IActionResult Details()
        {
            ViewData["Name"] = "John";
            ViewData["Age"] = 25;

            return View();
        }
    }
}
