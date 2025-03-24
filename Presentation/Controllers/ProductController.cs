using Application.IServices;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Presentation.Models;

namespace Presentation.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductsService _products;

        public ProductController(IProductsService products)
        {
            _products = products;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _products.GetAllAsync();
            if (products == null)
            {
                return BadRequest();
            }
            var productModels = products.Select(product => new Models.Products
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                CategoryId = product.CategoryId,
                IsHourly = product.IsHourly
            }).ToList();
            return View(productModels);
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Models.Products product)
        {
            if (ModelState.IsValid)
            {
                // Check the product name and set CategoryId accordingly
                if (product.Name.Contains("bia", StringComparison.OrdinalIgnoreCase) ||
                    product.Name.Contains("nước", StringComparison.OrdinalIgnoreCase))
                {
                    product.CategoryId = 2;
                }
                else
                {
                    product.CategoryId = 1;
                }

                Domain.Entities.Products newProduct = new Domain.Entities.Products
                {
                    Name = product.Name,
                    Price = product.Price,
                    CategoryId = product.CategoryId
                };
                await _products.AddAsync(newProduct);
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
