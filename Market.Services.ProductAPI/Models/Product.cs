using System.ComponentModel.DataAnnotations;

namespace Market.Services.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Range(1,10000)]
        public int Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? CategoryName { get; set; }

    }
}
