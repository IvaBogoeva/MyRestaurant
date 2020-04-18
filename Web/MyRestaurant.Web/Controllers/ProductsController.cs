namespace MyRestaurant.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MyRestaurant.Data.Common.Repositories;
    using MyRestaurant.Data.Models;
    using MyRestaurant.Services.Data;
    using MyRestaurant.Web.ViewModels.Categories;
    using MyRestaurant.Web.ViewModels.Products;

    public class ProductsController : Controller
    {
        private readonly IProductsService productService;
        private readonly ICategoriesService categoriesService;

        public ProductsController(IProductsService productService, ICategoriesService categoriesService)
        {
            this.productService = productService;
            this.categoriesService = categoriesService;
        }

        [Authorize]
        public IActionResult Create()
        {
            var categories = this.categoriesService.GetAll<CategoryDropDownViewModel>();
            var viewModel = new ProductCreateInputModel
            {
                Categories = categories,
            };

            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(ProductCreateInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var productId = await this.productService.CreateAsync
                (input.Name, input.Price, input.Weight, input.Description, input.CategoryId);
            return this.Redirect("/Home");
        }
    }
}
