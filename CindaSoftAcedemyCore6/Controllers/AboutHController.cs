using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Controllers
{
    [AllowAnonymous]
    public class AboutHController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
