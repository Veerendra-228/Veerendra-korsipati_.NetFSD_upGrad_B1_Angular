using Microsoft.AspNetCore.Mvc;
using MVC_ASSIGNMENT_2.Models;
using System.Collections.Generic;


namespace MVC_ASSIGNMENT_2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult TestStudent()
        {
            var student = new Student
            {
                Id = 1,
                Name = "Rahul",
                Age = 21,
                Email = "rahul@email.com",
                Courses = new List<Course>
                {
                    new Course { CourseId = 101, CourseName = "Math" },
                    new Course { CourseId = 102, CourseName = "Science" }
                }
            };

            return Json(student); // returns model as JSON
        }
    }
}