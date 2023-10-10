using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Education
    {
        [Key]
        public int EducationID { get; set; }
        public string? ImageUrl { get; set; }
        public string? EdicationName { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? Section { get; set; }
        public string? TeacImageUrl { get; set; }
        public int Time { get; set; }
        public int StudentCount { get; set; }
        public int AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

    }
}
