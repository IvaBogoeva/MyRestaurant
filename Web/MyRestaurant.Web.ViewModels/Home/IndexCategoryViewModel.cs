namespace MyRestaurant.Web.ViewModels.Home
{
    using MyRestaurant.Data.Models;
    using MyRestaurant.Services.Mapping;

    public class IndexCategoryViewModel : IMapFrom<Category>
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Url => $"/f/{this.Name.Replace(' ', '-')}";
    }
}
