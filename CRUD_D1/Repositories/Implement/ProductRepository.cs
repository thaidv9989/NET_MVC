using CRUD_D1.Data;
using CRUD_D1.Models;

namespace CRUD_D1.Repositories.Implement
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext _dbContext;

        public ProductRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddProduct(Product product)
        {
           _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var rs = _dbContext.Products.FirstOrDefault(p => p.Product_Id == id);
            if(rs == null)
            {
                throw new Exception("Not found this product with id: " + id);
            }
            
             _dbContext.Products.Remove(rs);
             _dbContext.SaveChanges();
            
        }

        public Product? GetProduct(int id)
        {
            return _dbContext.Products.FirstOrDefault(p => p.Product_Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public void UpdateProduct(Product product)
        {
            var rs = _dbContext.Products.FirstOrDefault(p=>p.Product_Id == product.Product_Id);
            if(rs == null)
            {
                throw new Exception("Not found this product with id: " + product.Product_Id);
            }
            rs.Product_Name = product.Product_Name;
            rs.Product_Img = product.Product_Img;
            rs.Description = product.Description;
            rs.Category_Id = product.Category_Id;
            rs.Price = product.Price;
            rs.UpdatedDate = DateTime.Now;
            _dbContext.Products.Update(rs);
            _dbContext.SaveChanges();
        }
    }
}
