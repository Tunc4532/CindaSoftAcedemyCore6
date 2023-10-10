using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Student.Controllers
{
    [Area("Student")]
    [AllowAnonymous]
    public class LessonAddController : Controller
    {
        [HttpGet]
        public IActionResult AddLesson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddLesson(string p)
        {
            return View();
        }
    }
}
