using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Student.ViewComponents
{
    public class _LessonComment : ViewComponent
    {
        private readonly ICommentTeacherService _commentTeacherService;

        public _LessonComment(ICommentTeacherService commentTeacherService)
        {
            _commentTeacherService = commentTeacherService;
        }

        public IViewComponentResult Invoke()
        {
            //şartlı listeleme gelecek
            var values = _commentTeacherService.TGetList();
            return View(values);
        }
    }
}
