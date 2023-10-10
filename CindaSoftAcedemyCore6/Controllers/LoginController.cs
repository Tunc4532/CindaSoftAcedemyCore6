using CindaSoftAcedemyCore6.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SıgnUp()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> SıgnUp(UserRegisterViewModel p)
        {
			AppUser appUser = new AppUser()
			{
				Name = p.Name,
				SurName = p.Surname,
				Email = p.Mail,
				UserName = p.Username
			};
			if (p.Password == p.ConfirmPassword)
			{
				var result = await _userManager.CreateAsync(appUser, p.Password);
				if (result.Succeeded)
				{
                    //ObServer Design Pattern Kodları bu alana gelecek kayıt olma işlemi başarılı bir şekilde olursa burada kullanıcıya otomatik mesaj gönderme metodu çağırılıp mesaj iletilecek 
                    //mail bültenine kayıt olursa kullanıcı buradaki yapı gibi olacak ve aynı alanda işlemler gerçekleştirilecek 
					return RedirectToAction("SıgnIn");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
				}
			}
			return View(p);
		}

        [HttpGet]
        public IActionResult SıgnIn()
        {
            return View();
        }
         
        [HttpPost]
        public async Task<IActionResult> SıgnIn(UserSıgnInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, true);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "ProfileA", new { area = "Student" });
                }
                else
                {
                    return RedirectToAction("SıgnIn", "Login");
                }
            }

            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("SıgnIn", "Login");
        }
    }
}
