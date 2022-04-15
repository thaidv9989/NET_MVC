using CRUD_D1.Models;
using CRUD_D1.Repositories;

namespace CRUD_D1.Service.Implement
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }

        public Product? GetProduct(int id)
        {
            return _productRepository.GetProduct(id);
        }

        public IEnumerable<Product> GetProducts()
        {
           return _productRepository.GetProducts();
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.UpdateProduct(product);
        }
    }
}
