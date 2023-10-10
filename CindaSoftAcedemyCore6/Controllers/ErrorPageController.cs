using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Controllers
{
  
    public class ErrorPageController : Controller
    {
        //hata sayfaları alanı 404 500 
        public IActionResult Index()
        {
            return View();
        }
    }
}
