using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Welcome
    {
        [Key]
        public int WelcomeID { get; set; }
        public string? Tittle { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }

    }
}
