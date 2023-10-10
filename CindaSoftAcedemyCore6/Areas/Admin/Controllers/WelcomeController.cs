using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WelcomeController : Controller
    {
        private readonly IWelcomeService _welcomeService;

        public WelcomeController(IWelcomeService welcomeService)
        {
            _welcomeService = welcomeService;
        }

        [HttpGet]
        public IActionResult EditWelcome()
        {
            var values = _welcomeService.TGetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditWelcome(Welcome welcome)
        {
            _welcomeService.TUpdate(welcome);
            return RedirectToAction("Index", "Default");
        }
    }
}
