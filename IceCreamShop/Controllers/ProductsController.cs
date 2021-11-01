using IceCreamShop.Models;

namespace IceCreamShop.Controllers
{
    public class ProductsController : BaseCrudController<Product>
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductsController(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
