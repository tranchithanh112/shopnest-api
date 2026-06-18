using Application.DTOs.Product;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.Service
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<ProductResponse> CreateProduct(CreateProductRequest product)
        {
            if(product.Price <= 0)
            {
                throw new ArgumentException("Price must greater than 0");
            }
            if(product.Stock < 0)
            {
                throw new ArgumentException("Stock must be greater than or equal to 0");
            }
            var createdProduct = await _productRepository.CreateProduct(_mapper.Map<Product>(product));
            return _mapper.Map<ProductResponse>(createdProduct);
        }
        public async Task<List<ProductResponse>> GetAllProducts()
        {
            var products = await _productRepository.GetAllProducts();
            return _mapper.Map<List<ProductResponse>>(products);
        }
        public async Task<ProductResponse> GetProductById(int id)
        {
            var product = await _productRepository.GetProductById(id);
            return _mapper.Map<ProductResponse>(product);
        }
        public async Task DeleteProduct(int id)
        {
            var existingProduct = await _productRepository.GetProductById(id)
            ?? throw new ArgumentException("Product not found");
            await _productRepository.DeleteProduct(id);
        }
        public async Task<ProductResponse> UpdateProduct(int id, UpdateProductRequest product)
        {
            var existingProduct = await _productRepository.GetProductById(id)
            ?? throw new ArgumentException("Product not found");
            if (product.Price <= 0)
            {
                throw new ArgumentException("Price must be greater than 0");
            }
            if (product.Stock < 0)
            {
                throw new ArgumentException("Stock must be greater than or equal to 0");
            }
            existingProduct.Updated = DateTimeOffset.UtcNow;
            _mapper.Map(product, existingProduct);
            await _productRepository.UpdateProduct(existingProduct);
            return _mapper.Map<ProductResponse>(existingProduct);
        }
    }
}
