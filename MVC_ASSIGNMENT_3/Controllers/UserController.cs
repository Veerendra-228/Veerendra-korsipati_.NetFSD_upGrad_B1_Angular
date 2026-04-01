using Microsoft.AspNetCore.Mvc;
using MVC_ASSIGNMENT_3.Models;
using MVC_ASSIGNMENT_3.ViewModels;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace MVC_ASSIGNMENT_3.Controllers
{
    public class UserController : Controller
    {
        // Fake database (for demo)
        private static List<User> users = new List<User>();

        // GET: Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: Register
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                users.Add(user);
                return RedirectToAction("Login");
            }
            return View(user);
        }

        // GET: Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                HttpContext.Session.SetString("UserEmail", user.Email);
                return RedirectToAction("Profile");
            }

            ViewBag.Error = "Invalid credentials";
            return View();
        }

        // GET: Profile
        public IActionResult Profile()
        {
            var email = HttpContext.Session.GetString("UserEmail");

            if (email == null)
                return RedirectToAction("Login");

            var user = users.FirstOrDefault(u => u.Email == email);

            var vm = new UserViewModel
            {
                Name = user.Name,
                Email = user.Email
            };

            return View(vm);
        }

        // GET: Edit
        public IActionResult Edit()
        {
            var email = HttpContext.Session.GetString("UserEmail");

            if (email == null)
                return RedirectToAction("Login");

            var user = users.FirstOrDefault(u => u.Email == email);
            return View(user);
        }

        // POST: Edit
        [HttpPost]
        public IActionResult Edit(User updatedUser)
        {
            var email = HttpContext.Session.GetString("UserEmail");

            var user = users.FirstOrDefault(u => u.Email == email);

            if (user != null)
            {
                user.Name = updatedUser.Name;
                user.Password = updatedUser.Password;
            }

            return RedirectToAction("Profile");
        }

        // Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}