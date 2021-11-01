using IceCreamShop.Models;

namespace IceCreamShop.Controllers
{
    public class CustomersController : BaseCrudController<Customer>
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomersController(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
