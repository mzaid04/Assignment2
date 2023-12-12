using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Model
{
    public class Student
    {
        [Key]
        public int sid { get; set; }

        public string sname { get; set; }
        [Required]
        public string major { get; set; }
        [Required]
        public string standing { get; set; }

        public List<Enrollment> Enrollments { get; set; }  
    }
}
