using Clover_Donuts_FE.Server.DataBase;
using Clover_Donuts_FE.Server.Entities;
using Clover_Donuts_FE.Server.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clover_Donuts_FE.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        private readonly CloverDonutsDbContext _cloverDonutsDbContext;

        public ProductController(CloverDonutsDbContext dbcontext, IProductRepository productRepository) { 
        
            _cloverDonutsDbContext = dbcontext;
            //could also do this.cloverDonutsDbContex = dbcontext;
            _productRepository = productRepository;
            //could also do this.productRepository = productRepository;
        }



        [HttpGet]
        public async Task<IEnumerable<Product>> GetItems()
            {
            var products = await _cloverDonutsDbContext.Products.ToListAsync();
            return Ok(products);
        }
    }
}
