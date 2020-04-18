namespace MyRestaurant.Web.ViewModels.Categories
{
    using MyRestaurant.Data.Models;
    using MyRestaurant.Services.Mapping;
    using System.Net;
    using System.Text.RegularExpressions;

    public class ProductsInCategoryViewModel : IMapFrom<Product>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Weight { get; set; }

        public decimal Price { get; set; }
    }
}
