using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string? NameSurname { get; set; }
        public string? Mail { get; set; }
        public string? Subject { get; set; }
        public string? MessageBody { get; set; }
        public DateTime Date { get; set; }
    }
}
