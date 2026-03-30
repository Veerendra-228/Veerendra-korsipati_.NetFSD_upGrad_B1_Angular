using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace MVC_Assignment_1.Controllers
{
    public class Assignment13Controller : Controller
    {
        public IActionResult Index()
        {
            List<string> students = new List<string>()
            {
                "Kavya",
                "Virat",
                "Pandya",
                "Krunal"
            };

            ViewData["Students"] = students;

            return View();
        }
    }
}
