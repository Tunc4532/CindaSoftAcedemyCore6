using BusinessLayer.Abstract;
using CindaSoftAcedemyCore6.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Controllers
{
	[AllowAnonymous]
	public class ContactHController : Controller
    {
        private readonly IContactService _contactService;

        public ContactHController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SendMessageViewModel sendMessage)
        {
            //moodel parametresi ile atama yapma işlemleri
            if (ModelState.IsValid) {
                _contactService.TAdd(new EntityLayer.Concrete.Contact()
                {
                    MessageBody =  sendMessage.MessageBody,
                    Mail = sendMessage.Mail,
                    NameSurname = sendMessage.NameSurname,
                    Subject = sendMessage.Subject,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
            }
            return RedirectToAction("Index", "Default");
        }

    }
}
