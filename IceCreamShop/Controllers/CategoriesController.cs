using IceCreamShop.Models;

namespace IceCreamShop.Controllers
{
    public class CategoriesController : BaseCrudController<Category>
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoriesController(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
