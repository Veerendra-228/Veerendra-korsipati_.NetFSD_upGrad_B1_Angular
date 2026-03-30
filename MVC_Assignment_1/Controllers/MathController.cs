using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_1.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Add(int a, int b)
        {
            int result = a + b;
            return Content($"Addition Result: {result}");
        }

        public IActionResult Multiply(int a, int b)
        {
            int result = a * b;
            return Content($"Multiplication Result: {result}");
        }
    }
}
