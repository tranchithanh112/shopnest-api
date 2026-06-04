using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public class CategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<Category> CreateCategory(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.Name))
                throw new ArgumentException("Category name is required");
            return await _categoryRepository.CreateCategory(category);
        }
        public async Task<List<Category>> GetAllCategories()
        {
            return await _categoryRepository.GetAllCategories();
        }
        public async Task<Category> GetCategoryById(int id)
        {
            return await _categoryRepository.GetCategoryById(id);
        }
        public async Task DeleteCategory(int id)
        {
            var existingCategory = await _categoryRepository.GetCategoryById(id)
            ?? throw new ArgumentException("Category not found");
            await _categoryRepository.DeleteCategory(id);
        }
        public async Task<Category> UpdateCategory(Category category)
        {
            var existingCategory = await _categoryRepository.GetCategoryById(category.Id)
            ?? throw new ArgumentException("Category not found");
            await _categoryRepository.UpdateCategory(category);
            return category;
        }
    }
}
