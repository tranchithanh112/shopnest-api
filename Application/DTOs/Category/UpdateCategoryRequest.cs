using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Category
{
    public class UpdateCategoryRequest
    {
        [Required]
        public string Name { get; set; }
    }
}
