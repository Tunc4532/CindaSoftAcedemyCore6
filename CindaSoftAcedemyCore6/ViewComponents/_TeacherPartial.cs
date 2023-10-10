using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.ViewComponents
{
    public class _TeacherPartial : ViewComponent
    {
        private readonly ITeacherService _teacherService;

        public _TeacherPartial(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _teacherService.TGetList();
            return View(values);
        }
    }
}
