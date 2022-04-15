using System.ComponentModel.DataAnnotations;

namespace CRUD_D1.Models
{
    public class Product
    {
        [Key]
        public int Product_Id { get; set; }
        public string? Product_Name { get; set; }
        public string Product_Img { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int? Category_Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
