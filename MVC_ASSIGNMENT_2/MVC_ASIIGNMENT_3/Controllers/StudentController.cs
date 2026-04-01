using Microsoft.AspNetCore.Mvc;
using MVC_ASIIGNMENT_3.Models;

namespace YourProjectName.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new Student
            {
                Id = 1,
                Name = "Rahul",
                Age = 21,
                Email = "rahul@email.com"
            };

            return View(student); // passing model to view
        }
    }
}