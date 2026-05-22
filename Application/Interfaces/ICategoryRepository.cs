using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllCategories();
        Task<Category> GetCategoryById(int id);
        Task DeleteCategory(int id);
        Task<Category> CreateCategory(Category category);
        Task<Category> UpdateCategory(Category category);
    }
}
