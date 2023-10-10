using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.ViewComponents
{
    public class _ArticlePartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _ArticlePartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _articleService.TGetList();
            return View(values);
        }
    }
}
