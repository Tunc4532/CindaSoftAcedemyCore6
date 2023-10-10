using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.ViewComponents
{
    public class _OnlineLessonPartial : ViewComponent
    {
        OnlineLessonManager _onlineLessonManager = new OnlineLessonManager(new EfOnlineLessonDal());
        public IViewComponentResult Invoke()
        {
            var values = _onlineLessonManager.TGetList();
            return View(values);
        }

    }
}
