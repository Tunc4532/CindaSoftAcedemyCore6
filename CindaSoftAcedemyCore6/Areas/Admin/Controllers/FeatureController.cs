using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class FeatureController : Controller
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        [HttpGet]
        public IActionResult EditFeature()
        {
            var values = _featureService.TGetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditFeature(Feature feature)
        {
            _featureService.TUpdate(feature);
            return RedirectToAction("Index", "Default");
        }
    }
}
