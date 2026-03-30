using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_1.Controllers
{
    public class Assignment10Controller : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Kavya";
            ViewData["Salary"] = 50000;
            ViewData["Department"] = "IT";

            return View();
        }
    }
}
