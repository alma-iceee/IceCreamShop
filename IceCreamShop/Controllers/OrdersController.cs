using IceCreamShop.Models;

namespace IceCreamShop.Controllers
{
    public class OrdersController : BaseCrudController<Order>
    {
        private readonly ApplicationDbContext _dbContext;

        public OrdersController(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
