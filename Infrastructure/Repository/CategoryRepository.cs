using Application.Interfaces;
using Domain.Entities;


namespace Infrastructure.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task<Category> CreateCategory(Category product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateCategory(Category product)
        {
            throw new NotImplementedException();
        }
    }
}
