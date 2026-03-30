using Microsoft.AspNetCore.Mvc;
using MVC_Assignment_1.Models;

namespace MVC_Assignment_1.Controllers
{
    public class Assignment14Controller : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student()
            {
                Name = "Kavya",
                Age = 23
            };

            return View(student);
        }
    }
}
