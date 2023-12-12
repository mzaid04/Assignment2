using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Model
{
    public class Class
    {
        [Key]
        public int cid { get; set; }

        public string name { get; set; }    

        public string room_number { get; set; }

        [ForeignKey(nameof(Faculty))]
        public int fid { get; set; }
        public  Faculty Faculty { get; set; }

        public List<Enrollment> Enrollments { get; set; }
    }
}
