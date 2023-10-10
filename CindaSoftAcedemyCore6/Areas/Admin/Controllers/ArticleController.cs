using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult Index()
        {
            var values = _articleService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddArticle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddArticle(Article article)
        {
            _articleService.TAdd(article);
            return RedirectToAction("Index", "Default");
        }

        public IActionResult DeleteArticle(int id)
        {
            var values = _articleService.TGetById(id);
            _articleService.TDelete(values);
            return RedirectToAction("Index", "Default");
        }
        [HttpGet]
        public IActionResult EditArticle(int id)
        {
            var values = _articleService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditArticle(Article article)
        {
            _articleService.TUpdate(article);
            return RedirectToAction("Index", "Default");
        }
    }
}
