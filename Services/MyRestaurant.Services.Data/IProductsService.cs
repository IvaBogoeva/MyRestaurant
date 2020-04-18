namespace MyRestaurant.Services.Data
{
    using System.Threading.Tasks;

    public interface IProductsService
    {
        Task<int> CreateAsync(string name, decimal price, string weight, string description, int categoryId);
    }
}
