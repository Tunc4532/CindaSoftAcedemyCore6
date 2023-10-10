using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Admin.ViewComponents.AdminDashboard
{
    public class _NewLessonPartial : ViewComponent
    {
        private readonly IEducationService _educationService;

        public _NewLessonPartial(IEducationService educationService)
        {
            _educationService = educationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _educationService.TGetList();
            return View(values);
        }
    }
}
