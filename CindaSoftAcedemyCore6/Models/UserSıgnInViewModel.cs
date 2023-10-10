using System.ComponentModel.DataAnnotations;

namespace CindaSoftAcedemyCore6.Models
{
    public class UserSıgnInViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz.")]
        public string? username { get; set; }

        [Required(ErrorMessage = "Lütfen şifreniizi giriniz.")]
        public string? password { get; set; }
    }
}
