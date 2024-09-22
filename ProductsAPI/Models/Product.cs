﻿using System.ComponentModel.DataAnnotations;

namespace ProductsAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name{ get; set; } = string.Empty;

        [Required]
        public double Price { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
