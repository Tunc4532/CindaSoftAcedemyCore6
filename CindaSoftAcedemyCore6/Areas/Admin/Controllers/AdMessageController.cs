using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdMessageController : Controller
    {
        private readonly IContactService _contactService;

        public AdMessageController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult SendMesage()
        {
            var values = _contactService.TGetList();
            return View(values);
        }

        public IActionResult SendMesageDetails(int id)
        {
            var values = _contactService.TGetById(id);
            return View(values);
        }
    }
}
