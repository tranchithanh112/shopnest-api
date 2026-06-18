using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Category
{
    public class CreateCategoryRequest
    {
        [Required]
        public string Name { get; set; }
    }
}
