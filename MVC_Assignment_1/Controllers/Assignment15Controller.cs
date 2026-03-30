using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_1.Controllers
{
    public class Assignment15Controller : Controller
    {
        public IActionResult Details(string name, int age)
        {
            ViewData["Name"] = name;
            ViewData["Age"] = age;

            return View();
        }
    }
}
