using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string? IconUrl { get; set; }
        public string? Tittle { get; set; }
        public string? Description { get; set; }

    }
}
