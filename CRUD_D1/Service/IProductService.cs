using CRUD_D1.Models;

namespace CRUD_D1.Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product? GetProduct(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
