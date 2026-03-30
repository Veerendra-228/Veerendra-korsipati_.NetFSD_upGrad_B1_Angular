using Microsoft.AspNetCore.Mvc;
using MVC_Assignment_1.Models;
using System.Diagnostics;

namespace MVC_Assignment_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index1()

        {
            return View();
        }

        public IActionResult About()
        {
            return Content("This is About Page");
        }

        public IActionResult Contact()
        {
            return Content("Contact us at support@test.com");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
