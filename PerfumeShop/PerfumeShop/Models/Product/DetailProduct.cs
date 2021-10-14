using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeShop.Models.Product
{
    public class DetailProduct : CreateProduct
    {
        public int ProductId { get; set; }
        [Display(Name = "Pictures")]
        public string PicturesPath { get; set; }
    }
}
