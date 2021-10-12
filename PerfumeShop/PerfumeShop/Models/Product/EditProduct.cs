using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeShop.Models.Product
{
    public class EditProduct : CreateProduct
    {
        public int ProductId { get; set; }
        public string ExistPicture { get; set; }
    }
}
