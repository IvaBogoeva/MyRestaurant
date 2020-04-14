namespace MyRestaurant.Web.Controllers
{
    using System.Diagnostics;

    using MyRestaurant.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using MyRestaurant.Data;
    using MyRestaurant.Web.ViewModels.Administration.Dashboard;
    using System.Linq;
    using MyRestaurant.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var viewModel = new ViewModels.Home.IndexViewModel();
            var categories = this.db.Categories.Select(x => new IndexCategoryViewModel
            {
                Name = x.Name,
                ImageUrl = x.ImageUrl,
            }).ToList();

            viewModel.Categories = categories;

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
