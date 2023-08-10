namespace IAshop.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;
    using IAshop.Data;
    using IAshop.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                ProductsCount = this.context.Products.Count(),
                CategoryCount = this.context.Categories.Count(),
                ImagesCount = this.context.Images.Count(),
            };

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
