using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PromotionController : Controller
    {
        private readonly IPromotionService _promotionService;

        public PromotionController(IPromotionService promotionService)
        {
            _promotionService = promotionService;
        }

        public IActionResult Index()
        {
            var values = _promotionService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPromotion()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPromotion(Promotion promotion)
        {
            _promotionService.TAdd(promotion);
            return RedirectToAction("Index", "Default");
        }

        public IActionResult DeletePromotion(int id)
        {
            var values = _promotionService.TGetById(id);
            _promotionService.TDelete(values);
            return RedirectToAction("Index", "Default");
        }
        [HttpGet]
        public IActionResult EditPromotion(int id)
        {
            var values = _promotionService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditPromotion(Promotion promotion)
        {
            _promotionService.TUpdate(promotion);
            return RedirectToAction("Index", "Default");
        }
    }
}
