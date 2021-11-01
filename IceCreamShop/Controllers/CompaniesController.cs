using IceCreamShop.Models;

namespace IceCreamShop.Controllers
{
    public class CompaniesController : BaseCrudController<Company>
    {
        private readonly ApplicationDbContext _dbContext;

        public CompaniesController(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
