using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        [Display(Name ="Customer Name")]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(15)]
        [Phone]
        public string Phone { get; set; }
        [MaxLength(100)]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
    }
}
