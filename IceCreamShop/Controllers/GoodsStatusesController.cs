using IceCreamShop.Models;

namespace IceCreamShop.Controllers
{
    public class GoodsStatusesController : BaseCrudController<GoodsStatus>
    {
        private readonly ApplicationDbContext _dbContext;

        public GoodsStatusesController(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
