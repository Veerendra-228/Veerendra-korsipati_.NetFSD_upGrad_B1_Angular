using System.Collections.Generic;

namespace MVC_ASSIGNMENT_2.Models
{
    public class Student
    {
        public int Id { get; set; }          // Primary Key
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        // Navigation Property (One Student → Many Courses)
        public List<Course> Courses { get; set; }
    }
}