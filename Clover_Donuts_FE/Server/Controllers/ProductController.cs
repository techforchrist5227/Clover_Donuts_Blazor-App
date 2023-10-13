using Clover_Donuts_FE.Server.DataBase;
using Clover_Donuts_FE.Server.Entities;
using Clover_Donuts_FE.Server.Repositories.Contracts;
using CloverDonuts.Models.DTO;
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
            public async Task<ActionResult<IEnumerable<ProductDTO>>> GetItems()
            {
                try
                {
                    var products = await _cloverDonutsDbContext.Products.ToListAsync();
                    var productCategories = await _cloverDonutsDbContext.ProductCategories.ToListAsync();

                    if (products == null || productCategories == null)
                    {
                        return NotFound("Products or Product Categories not found");
                    }

                    var result = new
                    {
                        Products = products,
                        ProductCategories = productCategories
                    };

                    return Ok(result);
                }
                catch (Exception)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
                }
            }


            [HttpGet("{id:int}")]

        public async Task<ActionResult<ProductDTO>> GetItem(int id)
        {
            var item = await _cloverDonutsDbContext.Products.Where(itemId => itemId .Id == id).FirstOrDefaultAsync();

            return Ok(item);
        }
    }
}
