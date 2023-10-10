using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.ViewComponents
{
    public class _PromotionPartial : ViewComponent
    {
        private readonly IPromotionService _promotionService;

        public _PromotionPartial(IPromotionService promotionService)
        {
            _promotionService = promotionService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _promotionService.TGetList();
            return View(values);
        }
    }
}
