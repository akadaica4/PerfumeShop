using Microsoft.AspNetCore.Mvc;
using PerfumeShop.Entities;
using PerfumeShop.Models.Category;
using PerfumeShop.Models.Product;
using PerfumeShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeShop.Controllers
{
    public class ShopController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IProductService productService;
        private static Category category = new Category();
        public ShopController(ICategoryService categoryService,IProductService productService)
        {
            this.categoryService = categoryService;
            this.productService = productService;
        }
        public IActionResult Index()
        { 
            return View(categoryService.Gets());
        }
        [Route("/Shop/ViewProduct/{catId}")]
        public IActionResult ViewProduct(int catId)
        {
            return View(productService.GetProductByCategoryId(catId));
        }
        [HttpGet]
        [Route("Shop/Detail/{productId}")]
        public IActionResult Detail(int productId)
        {
            var product = productService.Get(productId);
            var detailProduct = new DetailProduct()
            {
                CategoryId = product.CategoryId,
                ProductId = product.ProductId,
                PicturesPath = product.Pictures,
                Price = product.Price,
                ProductName = product.ProductName,
                Quantity = product.Quantity,
                Trademark = product.Trademark,
                DescriptionProduct = product.DescriptionProduct
            };
            ViewBag.Category = category;
            return View(detailProduct);
        }
    }
}
