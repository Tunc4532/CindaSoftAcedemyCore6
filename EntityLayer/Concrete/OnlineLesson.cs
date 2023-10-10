using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OnlineLesson
    {
        [Key]
        public int OnlineLessonID { get; set; }
        public string? Header { get; set; }
        public string? VideoUrl { get; set; }
        public string? Description { get; set; }
    }
}
