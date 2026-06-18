using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Service;
using Application.DTOs.Category;
using AutoMapper;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoryService _categoryService;


        public CategoriesController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryResponse>>> GetAll()
        {
            var categories = await _categoryService.GetAllCategories();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryResponse>> Get(int id)
        {
            var category = await _categoryService.GetCategoryById(id);
            if (category == null) return NotFound();
            return Ok(category);
        }

        [HttpPost]
        public async Task<ActionResult<CategoryResponse>> Create(CreateCategoryRequest createCategoryRequest)
        {
            var createdCategory = await _categoryService.CreateCategory(createCategoryRequest);
            return CreatedAtAction(nameof(Get), new { id = createdCategory.Id }, createdCategory);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCategory(int id, UpdateCategoryRequest updateCategoryRequest)
        {
            var updatedCategory = await _categoryService.UpdateCategory(id, updateCategoryRequest);
            return Ok(updatedCategory);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            await _categoryService.DeleteCategory(id);
            return NoContent();
        }
    }
}
