using CRUD_D1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUD_D1.EntityConfig
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne<Category>()
                .WithMany()
                .HasForeignKey(p=>p.Category_Id)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();  
        }
    }
}
