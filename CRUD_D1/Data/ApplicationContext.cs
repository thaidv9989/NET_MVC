using CRUD_D1.EntityConfig;
using CRUD_D1.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_D1.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        } 
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductConfig());
            builder.ApplyConfiguration(new CategoryConfig());

        }

    }
}
