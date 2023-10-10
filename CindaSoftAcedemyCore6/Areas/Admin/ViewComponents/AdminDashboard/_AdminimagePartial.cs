using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Admin.ViewComponents.AdminDashboard
{
    public class _AdminimagePartial : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _AdminimagePartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity?.Name);
            ViewBag.v1 = values.ImageUrl;
            ViewBag.v2 = values.Name + " " + values.SurName;
            return View();
        }
    }
}
