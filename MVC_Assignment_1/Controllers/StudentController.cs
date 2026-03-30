using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return Content("Student Home Page");
        }

        public IActionResult Profile()
        {
            return Content("Student Profile Page");
        }
    }
}
