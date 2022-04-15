﻿using System.ComponentModel.DataAnnotations;

namespace CRUD_D1.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        public string? Category_Name { get; set; }
    }
}
