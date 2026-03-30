using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_1.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return Content("Teacher Home Page");
        }

        public IActionResult Details()
        {
            return Content("Teacher Details Page");
        }
    }
}
