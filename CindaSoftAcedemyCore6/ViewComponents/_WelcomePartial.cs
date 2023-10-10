using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.ViewComponents
{
    public class _WelcomePartial : ViewComponent
    {
        private readonly IWelcomeService _welcomeService;

        public _WelcomePartial(IWelcomeService welcomeService)
        {
            _welcomeService = welcomeService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _welcomeService.TGetList();
            return View(values);
        }
    }
}
