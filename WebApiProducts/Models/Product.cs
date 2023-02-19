using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace WebApiProducts.Models
{
    public class Product
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 50, ErrorMessage = "El campo {0} supera los 50 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 500, ErrorMessage ="El campo {0} supera los 500 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]

        [Range(0, 999999999.99)]
        public double Price { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 100, ErrorMessage ="El campo {0} supera los 100 caracteres")]
        public string Family { get; set; }
    }
}
