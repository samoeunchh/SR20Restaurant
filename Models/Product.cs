using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        [Required]
        [MaxLength(10)]
        public string ProductCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int OnHand { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
