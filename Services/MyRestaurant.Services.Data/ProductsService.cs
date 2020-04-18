namespace MyRestaurant.Services.Data
{
    using System.Threading.Tasks;

    using MyRestaurant.Data.Common.Repositories;
    using MyRestaurant.Data.Models;

    public class ProductsService : IProductsService
    {
        private readonly IDeletableEntityRepository<Product> productsRepository;

        public ProductsService(IDeletableEntityRepository<Product> productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public async Task<int> CreateAsync(string name, decimal price, string weight, string description, int categoryId)
        {
            var product = new Product
            {
                Name = name,
                Price = price,
                Weight = weight,
                Description = description,
                CategoryId = categoryId,
            };

            await this.productsRepository.AddAsync(product);
            await this.productsRepository.SaveChangesAsync();

            return product.Id;
        }
    }
}
