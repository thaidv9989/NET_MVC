using CRUD_D1.Models;

namespace CRUD_D1.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product? GetProduct(int id);    
        void AddProduct(Product product);
        void UpdateProduct(Product product);    
        void DeleteProduct(int id);
    }
}
