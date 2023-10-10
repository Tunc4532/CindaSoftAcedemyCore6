using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.ViewComponents
{
    public class _CommentTeacherPartial : ViewComponent
    {
        private readonly ICommentTeacherService _commentTeacherService;

        public _CommentTeacherPartial(ICommentTeacherService commentTeacherService)
        {
            _commentTeacherService = commentTeacherService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _commentTeacherService.TGetList();
            return View(values);
        }
    }
}
