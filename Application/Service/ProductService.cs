using Application.Interfaces;
using Domain.Entities;

namespace Application.Service
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Product> CreateProduct(Product product)
        {
            if(product.Price <= 0)
            {
                throw new ArgumentException("Price must greater than 0");
            }
            if(product.Stock < 0)
            {
                throw new ArgumentException("Stock must be greater than or equal to 0");
            }
            product.Created = DateTimeOffset.UtcNow;
            return await _productRepository.CreateProduct(product);
        }
        public async Task<List<Product>> GetAllProducts()
        {
            return await _productRepository.GetAllProducts();
        }
        public async Task<Product> GetProductById(int id)
        {
            return await _productRepository.GetProductById(id);
        }
        public async Task DeleteProduct(int id)
        {
            var existingProduct = await _productRepository.GetProductById(id)
            ?? throw new ArgumentException("Product not found");
            await _productRepository.DeleteProduct(id);
        }
        public async Task<Product> UpdateProduct(Product product)
        {
            var existingProduct = await _productRepository.GetProductById(product.Id)
            ?? throw new ArgumentException("Product not found");
            if (product.Price <= 0)
            {
                throw new ArgumentException("Price must greater than 0");
            }
            if (product.Stock < 0)
            {
                throw new ArgumentException("Stock must be greater than or equal to 0");
            }
            product.Updated = DateTimeOffset.UtcNow;
            await _productRepository.UpdateProduct(product);
            return product;
        }
    }
}
