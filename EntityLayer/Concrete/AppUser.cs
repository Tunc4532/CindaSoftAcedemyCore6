using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string? ImageUrl { get; set; }
        public string? Name { get; set; }
        public string? SurName { get; set; }
       
        public List<Lesson>? Lessons { get; set; }
        public List<Announcement>? Announcements { get; set; }
        public List<Education>? Educations { get; set; }
       

    }
}
