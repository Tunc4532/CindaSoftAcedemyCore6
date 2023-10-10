using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Controllers
{
	[AllowAnonymous]
	public class EducationHController : Controller
    {
       private readonly IEducationService _educationService;

        public EducationHController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        public IActionResult Index()
        {
            var values = _educationService.TGetEducationWithSurname();
            return View(values);
        }

        [HttpGet]
        public IActionResult EducationDetails(int id)
        {
            var values = _educationService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EducationDetails(Education education)
        {
            return View();
        }


    }
}
