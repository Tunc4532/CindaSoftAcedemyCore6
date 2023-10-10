using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Lesson
    {
        public int LessonID { get; set; }
        public string? LessName { get; set; }
        public string? LessImage { get; set; }
        public string? LessUrl { get; set; }
        public string? Name { get; set; }
        public int AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
