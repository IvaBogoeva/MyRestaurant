namespace MyRestaurant.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using MyRestaurant.Data.Common.Repositories;
    using MyRestaurant.Data.Models;
    using MyRestaurant.Services.Mapping;

    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.categoriesRepository.All()
                 .To<T>()
                 .ToList();
        }

        public T GetByName<T>(string name)
        {
            var category = this.categoriesRepository
                .All()
                .Where(x => x.Name == name)
                .To<T>()
                .FirstOrDefault();
            return category;
        }
    }
}
