using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using CindaSoftAcedemyCore6.Areas.Student.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Student.Controllers
{
    [Area("Student")]
    public class ATMCardController : Controller
    {
        private readonly IEducationService _educationService;

        public ATMCardController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        [HttpGet]
        public IActionResult Cardinformation(int id)
        {
            var values = _educationService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Cardinformation(string p)
        {

            return View();
        }
    }
} 
