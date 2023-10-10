using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Student.Controllers
{
    [Area("Student")]
    [Route("Student/MessageA")]
    public class MessageAController : Controller
    {
        private readonly IWriterMesssageService _messsageService;
        
        private readonly UserManager<AppUser> _userManager;

        public MessageAController(UserManager<AppUser> userManager, IWriterMesssageService messsageService)
        {
            _userManager = userManager;
            _messsageService = messsageService;
        }

        [Route("")]
        [Route("ReceiverMessage")]
        public async Task <IActionResult> ReceiverMessage(string e)
        {
            var values = await _userManager.FindByNameAsync(User.Identity?.Name);
            e = values.Email;
            var messagelist = _messsageService.GetListReceiverMessage(e);
            return View(messagelist);
        }

        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity?.Name);
            p = values.Email;
            var messagelist = _messsageService.GetListSenderMessage(p);
            return View(messagelist);
        }

        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            WriterMesssage writerMessage = _messsageService.TGetById(id);
            return View(writerMessage);
        }

        [Route("ReceiverMessageDetails/{id}")]
        public IActionResult ReceiverMessageDetails(int id)
        {
            WriterMesssage writerMessage = _messsageService.TGetById(id);
            return View(writerMessage);
        }

        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(WriterMesssage p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity?.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.SurName;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            Context c = new Context();
            var usernamesurmane = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.SurName).FirstOrDefault();
            p.ReceiverName = usernamesurmane;
            p.SenderName = usernamesurmane;
            _messsageService.TAdd(p);
            return RedirectToAction("SenderMessage");
        }
    }
}

