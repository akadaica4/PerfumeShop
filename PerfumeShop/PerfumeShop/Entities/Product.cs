using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeShop.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(300)]
        public string ProductName { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Trademark { get; set; }
        [Required]
        public string Pictures { get; set; }
        [ForeignKey("Categories")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string DescriptionProduct { get; set; }
    }
}
