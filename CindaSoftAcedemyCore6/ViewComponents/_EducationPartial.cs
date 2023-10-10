using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.ViewComponents
{
    public class _EducationPartial : ViewComponent
    {
        private readonly IEducationService _educationService;

        public _EducationPartial(IEducationService educationService)
        {
            _educationService = educationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _educationService.TGetEducationWithSurname();
            return View(values);
        }
    }
}
