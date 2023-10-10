using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Student.ViewComponents
{
    public class _UserStatisticPartial : ViewComponent
    {
        private readonly IAnnouncementService _announcementService;
          Context data = new Context();

        public _UserStatisticPartial(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Data1 = data.Announcements.Count();
            return View();
        }
    }
}
