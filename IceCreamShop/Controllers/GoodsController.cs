using IceCreamShop.Models;

namespace IceCreamShop.Controllers
{
    public class GoodsController : BaseCrudController<Goods>
    {
        private readonly ApplicationDbContext _dbContext;

        public GoodsController(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
