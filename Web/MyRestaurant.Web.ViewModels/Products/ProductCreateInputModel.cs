namespace MyRestaurant.Web.ViewModels.Products
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ProductCreateInputModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Weight { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Description { get; set; }

        [Range(1, 25)]
        public int CategoryId { get; set; }

        public IEnumerable<CategoryDropDownViewModel> Categories { get; set; }
    }
}
