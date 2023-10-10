using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Admin.ViewComponents.AdminDashboard
{
    public class _AStatisticPartial : ViewComponent
    {
        Context c = new Context();  
        public IViewComponentResult Invoke()
        {
           ViewBag.message = c.Contacts.Count();
           ViewBag.education = c.Educations.Count();
           ViewBag.lessoncount = c.Lessons.Count();

            return View();
        }
    }
}
