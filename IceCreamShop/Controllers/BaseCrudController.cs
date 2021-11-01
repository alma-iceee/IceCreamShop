using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;

namespace IceCreamShop.Controllers
{
    public interface IBaseCrudController<T> where T : class
    {
        [HttpDelete]
        [EnableQuery]
        public IActionResult Delete(int key);

        [EnableQuery]
        [HttpGet]
        public IActionResult Get();

        [EnableQuery]
        [HttpGet]
        public IActionResult Get(int key);

        [HttpPost]
        public IActionResult Post([FromBody] T model);

        [EnableQuery]
        [HttpPut]
        public IActionResult Put(int key, [FromBody] Delta<T> model);
    }

    public class BaseCrudController<T> : ODataController , IBaseCrudController<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;

        public BaseCrudController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Delete(int key)
        {
            var dbSet = _dbContext.Set<T>();
            var record = GetModelById(dbSet, key);

            if (record == null)
            {
                return NotFound($"Not found record with id = {key}");
            }

            dbSet.Remove(record);
            _dbContext.SaveChanges();

            return Ok();
        }

        public IActionResult Get()
        {
            return Ok(_dbContext.Set<T>());
        }

        public IActionResult Get(int key)
        {
            var record = GetModelById(_dbContext.Set<T>(), key);

            if (record == null)
            {
                return NotFound($"Not found record with id = {key}");
            }

            return Ok(record);
        }

        public IActionResult Post([FromBody] T model)
        {
            var dbSet = _dbContext.Set<T>();

            dbSet.Add(model);
            _dbContext.SaveChanges();

            return Created(model);
        }

        public IActionResult Put(int key, [FromBody] Delta<T> model)
        {
            var record = GetModelById(_dbContext.Set<T>(), key);

            if (record == null)
            {
                return NotFound($"Not found customer with id = {key}");
            }

            model.Put(record);
            _dbContext.SaveChanges();

            return Updated(record);
        }

        private static T GetModelById(DbSet<T> dbSet, int key)
        {
            foreach (var model in dbSet)
            {
                if ((int)model.GetType().GetProperty("Id").GetValue(model) == key)
                {
                    return model;
                }
            }

            return null;
        }
    }
}
