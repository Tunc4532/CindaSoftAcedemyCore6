namespace CindaSoftAcedemyCore6.Areas.Student.Models
{
    public class UserEditViewModel
    {
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? password { get; set; }
        public string? confirmpassword { get; set; }
        public string? username { get; set; }
        public string? email { get; set; }
        public string? imageurl { get; set; }
        public IFormFile? image { get; set; }
    }
}
