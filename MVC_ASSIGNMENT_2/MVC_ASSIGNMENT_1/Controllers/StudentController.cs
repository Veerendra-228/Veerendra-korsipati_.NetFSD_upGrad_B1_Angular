using Microsoft.AspNetCore.Mvc;

namespace MVC_ASSIGNMENT_1.Controllers
{
    public class StudentController : Controller
    {
        // 1. Index Action
        public IActionResult Index()
        {
            return Content("Welcome to Student Page");
        }

        // 2. Details Action
        public IActionResult Details()
        {
            return Content("Student Details Page");
        }

        // 3. Parameterized Action
        public IActionResult GetStudent(int id)
        {
            return Content($"Student ID is {id}");
        }
    }
}