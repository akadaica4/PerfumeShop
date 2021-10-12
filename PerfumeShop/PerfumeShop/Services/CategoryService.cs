using Microsoft.EntityFrameworkCore;
using PerfumeShop.Contexts;
using PerfumeShop.Entities;
using PerfumeShop.Models.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeShop.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly PerfumeShopDBContext context;

        public CategoryService(PerfumeShopDBContext context)
        {
            this.context = context;
        }

        public bool ChageStatus(int categoryId)
        {
            try
            {
                var category = Get(categoryId);
                category.Status = !category.Status;
                context.Attach(category);
                context.Entry(category).State = EntityState.Modified;
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool Create(Create create)
        {
            try
            {
                var caregory = new Category()
                {
                    CategoryName = create.CategoryName,
                    Description = create.Description,
                };
                context.Add(caregory);
                return context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Edit(Edit edit)
        {
            try
            {
                var category = Get(edit.CategoryId);
                category.CategoryName = edit.CategoryName;
                category.Description = edit.Description;
                category.CategoryId = edit.CategoryId;
                category.Status = edit.Status;
                context.Attach(category);
                context.Entry(category).State = EntityState.Modified;
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public Category Get(int CategoryId)
        {
            return context.Categories.FirstOrDefault(c => c.CategoryId == CategoryId);
        }

        public List<Category> Gets()
        {
            return context.Categories.Include(p => p.Products).ToList();
        }
    }
}
