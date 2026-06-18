using Application.DTOs.Category;
using Application.DTOs.Product;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping
{
    public class MappingProfile:Profile
    {
            public MappingProfile()
            {
            // Category Mappings
                CreateMap<Category,CategoryResponse>();
                CreateMap<CreateCategoryRequest, Category>();
                CreateMap<UpdateCategoryRequest, Category>();
                

            // Product Mappings
                CreateMap<Product,ProductResponse>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));
                CreateMap<CreateProductRequest, Product>();
                CreateMap<UpdateProductRequest, Product>();
        }
    }
}
