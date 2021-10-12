using PerfumeShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeShop.Services
{
    public interface IProductService
    {
        List<Product> GetProductByCategoryId(int categoryId);
        bool Create(Product model);
        bool Edit(Product model);
        Product Get(int productId);
    }
}
