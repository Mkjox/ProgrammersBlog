using Microsoft.AspNetCore.Mvc;
using ProgrammersBlog.Services.Abstract;

namespace ProgrammersBlog.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleService _articleService;

        public HomeController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int? categoryId)
        {
            var articlesResult = await (categoryId == null ? _articleService.GetAllByNonDeletedAndActiveAsync() : _articleService.GetAllByCategoryAsync(categoryId.Value));
            return View(articlesResult.Data);
        }
    }
}
