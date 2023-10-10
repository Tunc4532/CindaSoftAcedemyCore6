using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Student.Controllers
{
    [Area("Student")]
    public class MyLessonController : Controller
    {
        private readonly ILessonService _lessonService;
        private readonly UserManager<AppUser> _userManager;

        public MyLessonController(UserManager<AppUser> userManager, ILessonService lessonService)
        {
            _userManager = userManager;
            _lessonService = lessonService;
        }

        public async Task<IActionResult> Index(string? r)
        {
            var values = await _userManager.FindByNameAsync(User.Identity?.Name);
            r = values.Name;
            var leslist = _lessonService.TGetLessonListById(r);
            return View(leslist);

        }

        public IActionResult WatchLesson(int id)
        {
            Lesson lesson = _lessonService.TGetById(id);
            return View(lesson);
        }
    }
}
