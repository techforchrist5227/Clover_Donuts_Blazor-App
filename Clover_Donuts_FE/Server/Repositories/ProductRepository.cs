using Clover_Donuts_FE.Server.DataBase;
using Clover_Donuts_FE.Server.Entities;
using Clover_Donuts_FE.Server.Repositories.Contracts;

namespace Clover_Donuts_FE.Server.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CloverDonutsDbContext _cloverDonutsDbContext;
        
        // db context constructor
        public ProductRepository(CloverDonutsDbContext cloverDonutsDbContext)
        {
            _cloverDonutsDbContext = cloverDonutsDbContext;
        }
        public Task<IEnumerable<ProductCategory>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
