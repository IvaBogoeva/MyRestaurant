namespace MyRestaurant.Web.ViewModels.Categories
{
    using System.Collections.Generic;

    using MyRestaurant.Data.Models;
    using MyRestaurant.Services.Mapping;

    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<ProductsInCategoryViewModel> Products { get; set; }
    }
}
