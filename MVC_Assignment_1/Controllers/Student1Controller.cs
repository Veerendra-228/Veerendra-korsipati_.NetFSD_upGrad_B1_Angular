using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_1.Controllers
{
    public class Student1Controller : Controller
    {
        public IActionResult Details()
        {
            ViewBag.Name = "Kavya";
            ViewBag.Age = 22;

            return View();
        }
    }
}
