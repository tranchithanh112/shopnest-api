using Application.DTOs.Category;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.Service
{
    public class CategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryResponse> CreateCategory(CreateCategoryRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
                throw new ArgumentException("Category name is required");

            var category = _mapper.Map<Category>(request);
            var created = await _categoryRepository.CreateCategory(category);
            return _mapper.Map<CategoryResponse>(created);
        }

        public async Task<List<CategoryResponse>> GetAllCategories()
        {
            var categories = await _categoryRepository.GetAllCategories();
            return _mapper.Map<List<CategoryResponse>>(categories);
        }

        public async Task<CategoryResponse?> GetCategoryById(int id)
        {
            var category = await _categoryRepository.GetCategoryById(id);
            return category is null ? null : _mapper.Map<CategoryResponse>(category);
        }

        public async Task DeleteCategory(int id)
        {
            _ = await _categoryRepository.GetCategoryById(id)
                ?? throw new ArgumentException("Category not found");
            await _categoryRepository.DeleteCategory(id);
        }

        public async Task<CategoryResponse> UpdateCategory(int id, UpdateCategoryRequest request)
        {
            var existingCategory = await _categoryRepository.GetCategoryById(id)
                ?? throw new ArgumentException("Category not found");

            existingCategory.Name = request.Name;
            await _categoryRepository.UpdateCategory(existingCategory);
            return _mapper.Map<CategoryResponse>(existingCategory);
        }
    }
}
