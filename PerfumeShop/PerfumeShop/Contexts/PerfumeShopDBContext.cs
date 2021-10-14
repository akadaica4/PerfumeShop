using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PerfumeShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeShop.Contexts
{
    public class PerfumeShopDBContext : IdentityDbContext<AppUser>
    {
        public PerfumeShopDBContext(DbContextOptions<PerfumeShopDBContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedingCategory(modelBuilder);
            SeedingProduct(modelBuilder);
            SeedingUsers(modelBuilder);
            SeedingRoles(modelBuilder);
            SeedingUserRoles(modelBuilder);
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
        private void SeedingUsers(ModelBuilder builder)
        {
            AppUser user = new AppUser()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "Nam Tran",
                Email = "nhatnamtran100217@gmail.com",
                NormalizedEmail = "nhatnamtran100217@gmail.com",
                NormalizedUserName = "nam tran",
                LockoutEnabled = false,
                PhoneNumber = "0357373803",
                Avatar = "~/images/avatar.jpg"
            };

            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            user.PasswordHash = passwordHasher.HashPassword(user, "Asdf1234!");

            builder.Entity<AppUser>().HasData(user);
        }
        private void SeedingRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "SystemAdmin", ConcurrencyStamp = "1", NormalizedName = "System Admin" },
                new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "Admin", ConcurrencyStamp = "2", NormalizedName = "Admin" }
                );
        }
        private void SeedingUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" }
                );
        }
        #endregion
    }
}
