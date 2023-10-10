using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult EditAbout()
        {
            var values = _aboutService.TGetById(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditAbout(About about)
        {
            _aboutService.TUpdate(about);
            return RedirectToAction("Index", "Default");
        }

    }
}
