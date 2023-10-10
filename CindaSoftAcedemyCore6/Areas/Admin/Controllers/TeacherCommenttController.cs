using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class TeacherCommenttController : Controller
    {
        private readonly ICommentTeacherService _commentTeacherService;

        public TeacherCommenttController(ICommentTeacherService commentTeacherService)
        {
            _commentTeacherService = commentTeacherService;
        }

        public IActionResult Index()
        {
            var values = _commentTeacherService.TGetList();
            return View(values);
        }

        public IActionResult DeleteTeacherComment(int id)
        {
            var values = _commentTeacherService.TGetById(id);
            _commentTeacherService.TDelete(values);
            return RedirectToAction("Index", "Default");
        }

        [HttpGet]
        public IActionResult AddTeacherComment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTeacherComment(CommentTeacher commentTeacher)
        {
            _commentTeacherService.TAdd(commentTeacher);
            return RedirectToAction("Index", "Default");
        }

        [HttpGet]
        public IActionResult EditTeacherComment(int id)
        {
            var values = _commentTeacherService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTeacherComment(CommentTeacher commentTeacher)
        {
            _commentTeacherService.TUpdate(commentTeacher);
            return RedirectToAction("Index", "Default");
        }
    }
}
