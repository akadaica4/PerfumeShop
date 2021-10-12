using Microsoft.EntityFrameworkCore;
using PerfumeShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeShop.Contexts
{
    public class PerfumeShopDBContext : DbContext
    {
        public PerfumeShopDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedingCategory(modelBuilder);
            SeedingProduct(modelBuilder);
        }
        #region seeding
        private void SeedingCategory(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Nước Hoa Nam",
                    Description = "Nước hoa thường thượng nam tính",
                    Status = true
                },
                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "Nước Hoa Nữ",
                    Description = "Quyến rũ",
                    Status = true
                });
        }
        private void SeedingProduct(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    ProductName = "Chanel",
                    Price = 18000000,
                    Quantity = 12,
                    Pictures = "~/images/chanel.jpg",
                    CategoryId = 1,
                    Trademark = "Chanel",
                    DescriptionProduct= "Chanel luôn nằm trong danh sách mẫu nước hoa đắt đỏ bán chạy nhất"
                },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "Shalimar",
                    Price = 12000000,
                    Quantity = 10,
                    Pictures = "~/images/shalimar.jpg",
                    CategoryId = 2,
                    Trademark = "Guerlain",
                    DescriptionProduct= "Shalimar là chai nước hoa được sáng tạo bởi Jacques Guerlain"
                });
        }
        #endregion
    }
}
