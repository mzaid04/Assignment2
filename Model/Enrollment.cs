using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Model
{
    public class Enrollment
    {
        [Key]
        public int eid { get; set; }

        [ForeignKey(nameof(Class))]
        public int cid { get; set; }
        public Class Class { get; set; }



        [ForeignKey(nameof(Student))]
        public int sid { get; set; }
        public Student Student { get; set; }

    }
}
