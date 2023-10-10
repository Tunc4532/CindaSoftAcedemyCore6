using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OnlineLessonController : Controller
    {
        private readonly IOnlineLessonService _onlineLessonService;

        public OnlineLessonController(IOnlineLessonService onlineLessonService)
        {
            _onlineLessonService = onlineLessonService;
        }

        [HttpGet]
        public IActionResult EdittOnlineLesson()
        {
            var values = _onlineLessonService.TGetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult EdittOnlineLesson(OnlineLesson onlineLesson)
        {
            _onlineLessonService.TUpdate(onlineLesson);
            return RedirectToAction("Index","Default");
        }
    }
}
