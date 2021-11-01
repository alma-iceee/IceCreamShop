using IceCreamShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace IceCreamShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("/makeOrder")]
        public IActionResult MakeOrder([FromBody] Order order)
        {
            var customer = _dbContext.Customers.FirstOrDefault(c => c.Id == order.CustomerId);
            if (customer == null)
            {
                return NotFound($"Not found customer with id = {order.CustomerId}");
            }

            var goods = _dbContext.Goods.FirstOrDefault(i => i.Id == order.GoodsId);
            if (goods == null)
            {
                return NotFound($"Not found ice cream with id = {order.GoodsId}");
            }
            if (goods.GoodsStatusId == 2)
            {
                return NotFound($"Ice cream with id = {order.GoodsId} is sold");
            }

            _dbContext.Orders.Add(order);

            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
