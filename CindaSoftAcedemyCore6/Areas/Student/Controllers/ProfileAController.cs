using CindaSoftAcedemyCore6.Areas.Student.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Student.Controllers
{
    [Area("Student")]
	[Route("Student/[controller]/[action]")]
	public class ProfileAController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileAController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task <IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity?.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.name = values.Name;
            userEditViewModel.surname = values.SurName;
            userEditViewModel.username = values.UserName;
            userEditViewModel.email = values.Email;
            ViewBag.namesurname = values.Name + " " + values.SurName;
            ViewBag.userimage = values.ImageUrl;
            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity?.Name);
            if (p.image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/Userimages/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.image.CopyToAsync(stream);
                values.ImageUrl = imagename;

            }
            values.Name = p.name;
            values.SurName = p.surname;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, p.password);
            var result = await _userManager.UpdateAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("SıgnIn", "Login");
            }

            return View();
        }
    }
}
