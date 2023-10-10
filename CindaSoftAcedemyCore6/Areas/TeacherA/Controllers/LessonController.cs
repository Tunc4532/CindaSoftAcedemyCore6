using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.TeacherA.Controllers
{
    [Area("TeacherA")]
    [AllowAnonymous]

    public class LessonController : Controller
    {
        private readonly IEducationService _educationService;
        private readonly UserManager<AppUser> _userManager;

        public LessonController(IEducationService educationService, UserManager<AppUser> userManager)
        {
            _educationService = educationService;
            _userManager = userManager;
        }

        public async Task<IActionResult> LessonList(string? r)
        {
            var values = await _userManager.FindByNameAsync(User.Identity?.Name);
            r = values.Name;
            var leslist = _educationService.TGetEducationListName(r);
            return View(leslist);

        }


        [HttpGet]
        public IActionResult AddLesson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddLesson(Education education)
        {
            education.AppUserId = 4;
            education.Name = "Murat";
            education.StudentCount = 1;
            _educationService.TAdd(education);
            return RedirectToAction("Index", "ProfileA");
        }


        public IActionResult DeleteLesson(int id)
        {
            var values = _educationService.TGetById(id);
            _educationService.TDelete(values);
            return RedirectToAction("Index", "ProfileA");
        }

        [HttpGet]
        public IActionResult EditLesson(int id)
        {
            var values = _educationService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditLesson(Education education)
        {
            education.StudentCount = 1;
            _educationService.TUpdate(education);
            return RedirectToAction("Index","Default");
        }
    }
}
