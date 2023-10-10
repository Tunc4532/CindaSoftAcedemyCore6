using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Views.Shared.Components
{
    public class _StatisticsPartial : ViewComponent
    {
        // private readonly ile generic methot kullanılacak amaç birden fazla manager servisi ile o sınıfa ait
        //veriyi çekmek 

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
