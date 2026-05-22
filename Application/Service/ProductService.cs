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
        public Task<Product> CreateProduct(Product product)
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
            return _productRepository.CreateProduct(product);
        }
        public  Task<List<Product>> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }
        public Task<Product> GetProductById(int id)
        {        
            return _productRepository.GetProductById(id);
        }
        public Task DeleteProduct(int id)
        {
            return _productRepository.DeleteProduct(id);
        }
        public Task<Product> UpdateProduct(Product product)
        {
            if (product.Price <= 0)
            {
                throw new ArgumentException("Price must greater than 0");
            }
            if (product.Stock < 0)
            {
                throw new ArgumentException("Stock must be greater than or equal to 0");
            }
            product.Updated = DateTimeOffset.UtcNow;
            return _productRepository.UpdateProduct(product);
        }
    }
}
