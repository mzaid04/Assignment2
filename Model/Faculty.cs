using System.ComponentModel.DataAnnotations;

namespace Assignment.Model
{
    public class Faculty
    {
        [Key]
        public int fid { get; set; }

        [Required]
        public string fname { get; set; }
        [Required]
        public int deptid { get; set; }
        [Required]
        public string standing { get; set; }

        public List<Class> Class { get; set; }
    }

}

