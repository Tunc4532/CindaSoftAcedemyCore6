using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class TCourseController : Controller
    {
        private readonly ICourseService _courseService;

        public TCourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _courseService.TGetList();
            return View(values);
        }

        public IActionResult DeleteCourse(int id)
        {
            var values = _courseService.TGetById(id);
            _courseService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            _courseService.TAdd(course);
            return RedirectToAction("Index", "ProfileA");
        }

        [HttpGet]
        public IActionResult UpdateCourse(int id)
        {
            var values = _courseService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCourse(Course course)
        {
            _courseService.TUpdate(course);
            return RedirectToAction("Index","Default");
        }
    }
}
