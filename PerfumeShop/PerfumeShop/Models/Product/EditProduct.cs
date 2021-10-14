using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeShop.Models.Product
{
    public class EditProduct 
    {
        [Required]
        [StringLength(300)]
        public string ProductName { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        public IFormFile Pictures { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public string Trademark { get; set; }
        [Required]
        public string DescriptionProduct { get; set; }
        public int ProductId { get; set; }
        public string ExistPicture { get; set; }
    }
}
