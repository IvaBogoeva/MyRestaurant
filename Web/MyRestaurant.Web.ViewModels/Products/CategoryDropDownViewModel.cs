namespace MyRestaurant.Web.ViewModels.Products
{
    using MyRestaurant.Data.Models;
    using MyRestaurant.Services.Mapping;

    public class CategoryDropDownViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
