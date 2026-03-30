using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProduct(int id)
        {
            return Content($"Product Id is: {id}");
        }
    }
}
