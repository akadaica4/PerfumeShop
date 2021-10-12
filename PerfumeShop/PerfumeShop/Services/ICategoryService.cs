using PerfumeShop.Entities;
using PerfumeShop.Models.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeShop.Services
{
    public interface ICategoryService
    {
        List<Category> Gets();
        Category Get(int CategoryId);
        bool Create(Create create);
        bool Edit(Edit edit);
        bool ChageStatus(int categoryId);
    }
}
