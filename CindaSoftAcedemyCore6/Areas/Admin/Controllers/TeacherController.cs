using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public IActionResult Index()
        {
            var values = _teacherService.TGetList();
            return View(values);
        }

        public IActionResult DeleteTeacher(int id)
        {
            var values = _teacherService.TGetById(id);
            _teacherService.TDelete(values);
            return RedirectToAction("Index", "Default");
        }

        [HttpGet]
        public IActionResult AddTeacher()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {
            _teacherService.TAdd(teacher);
            return RedirectToAction("Index", "Default");
        }

        [HttpGet]
        public IActionResult EditTeacher(int id)
        {
            var values = _teacherService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTeacher(Teacher teacher)
        {
            _teacherService.TUpdate(teacher);
            return RedirectToAction("Index", "Default");
        }
    }
}
