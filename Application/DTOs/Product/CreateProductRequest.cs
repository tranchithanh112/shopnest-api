using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Product
{
    public class CreateProductRequest
    {
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;
    }
}
