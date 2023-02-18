using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace WebApiProducts.Models
{
    public class Product
    {
        
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 500)]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Family { get; set; }
    }
}
