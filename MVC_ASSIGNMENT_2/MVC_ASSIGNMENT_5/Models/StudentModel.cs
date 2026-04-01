using System.ComponentModel.DataAnnotations;

namespace MVC_ASSIGNMENT_5.Models
{
    public class Student
    {
        public int Id { get; set; }   // Primary Key

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
    }
}