namespace MyRestaurant.Data.Models
{
    using System.Collections.Generic;

    using MyRestaurant.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

        public string ImageUrl { get; set; }
    }
}
