using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Announcement
    {
        [Key]
        public int AnnouncementId { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public DateTime Date { get; set; }
        public int AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
