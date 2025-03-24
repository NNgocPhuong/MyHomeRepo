using Application.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IProductsService _products;
        private readonly IRoomService _rooms;
        public PaymentController(IProductsService products, IRoomService rooms)
        {
            _products = products;
            _rooms = rooms;
        }

        public async Task<IActionResult> Index(int id)
        {
            var products = await _products.GetAllAsync();
            var room = await _rooms.GetRoomByIdAsync(id);
            if(room == null)
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
    }
}
