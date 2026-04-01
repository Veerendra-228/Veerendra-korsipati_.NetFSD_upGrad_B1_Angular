using MVC_ASSIGNMENT_2.Models;

namespace MVC_ASSIGNMENT_2.Models
{
    public class Course
    {
        public int CourseId { get; set; }     // Primary Key
        public string CourseName { get; set; }

        // Foreign Key
        public int StudentId { get; set; }

        // Navigation Property (Many Courses → One Student)
        public Student Student { get; set; }
    }
}