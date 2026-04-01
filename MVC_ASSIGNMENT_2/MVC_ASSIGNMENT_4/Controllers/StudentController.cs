using Microsoft.AspNetCore.Mvc;

namespace MVC_ASSIGNMENT_4.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult ViewBagDemo()
        {
            // Using ViewBag (dynamic)
            ViewBag.StudentName = "Rahul";

            // Using ViewData (dictionary)
            ViewData["StudentAge"] = 21;

            return View();
        }
    }
}