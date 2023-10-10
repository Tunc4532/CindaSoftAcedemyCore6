using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Student.Controllers
{
    [Area("Student")]
    public class StuAnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public StuAnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult AnnouncementList()
        {
            var values = _announcementService.TGetList();
            return View(values);
        }

        public IActionResult AnnouncementDetails(int id)
        {
            Announcement announcement = _announcementService.TGetById(id);
            return View(announcement);
        }
    }
}
