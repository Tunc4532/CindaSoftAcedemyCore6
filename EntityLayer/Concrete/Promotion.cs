using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Promotion
    {
        [Key]
        public int PromotionID { get; set; }
        public string? Header { get; set; }
        public string? Tittle { get; set; }
        public string? Description { get; set; }

    }
}
