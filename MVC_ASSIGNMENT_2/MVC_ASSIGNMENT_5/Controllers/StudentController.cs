using Microsoft.AspNetCore.Mvc;
using MVC_ASSIGNMENT_5.Data;
using MVC_ASSIGNMENT_5.Models;
using System.Linq;

namespace MVC_ASSIGNMENT_5.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // READ (List)
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

        // CREATE (GET)
        public IActionResult Create()
        {
            return View();
        }

        // CREATE (POST)
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // EDIT (GET)
        public IActionResult Edit(int id)
        {
            var student = _context.Students.Find(id);
            return View(student);
        }

        // EDIT (POST)
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // DELETE (GET)
        public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id);
            return View(student);
        }

        // DELETE (POST)
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}