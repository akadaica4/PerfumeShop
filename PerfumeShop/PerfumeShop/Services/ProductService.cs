using Microsoft.EntityFrameworkCore;
using PerfumeShop.Contexts;
using PerfumeShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeShop.Services
{
    public class ProductService : IProductService
    {
        private readonly PerfumeShopDBContext context;

        public ProductService(PerfumeShopDBContext context)
        {
            this.context = context;
        }
        public bool Create(Product model)
        {
            try
            {
                context.Add(model);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool Edit(Product product)
        {
            try
            {
                context.Attach(product);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public Product Get(int productId)
        {
            return context.Products.Include(p => p.Category).FirstOrDefault(p => p.ProductId == productId);
        }

        public List<Product> GetProductByCategoryId(int categoryId)
        {
            return context.Products.Include(p => p.Category).Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
