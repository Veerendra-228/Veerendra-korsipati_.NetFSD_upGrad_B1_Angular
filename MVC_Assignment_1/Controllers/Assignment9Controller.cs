using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_1.Controllers
{
    public class Assignment9Controller : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Home Page";
            return View();
        }
    }
}
