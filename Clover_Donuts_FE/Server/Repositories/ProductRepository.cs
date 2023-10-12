using Clover_Donuts_FE.Server.DataBase;
using Clover_Donuts_FE.Server.Entities;
using Clover_Donuts_FE.Server.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Clover_Donuts_FE.Server.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CloverDonutsDbContext cloverDonutsDbContext;
        
        // db context constructor
        public ProductRepository(CloverDonutsDbContext cloverDonutsDbContext)
        {
            this.cloverDonutsDbContext = cloverDonutsDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.cloverDonutsDbContext.ProductCategories.ToListAsync();
            return categories;
        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            //"Where" is used to filter productcategories dbset based on the ID
            var category = await this.cloverDonutsDbContext.ProductCategories.Where(catId=>catId.Id == id).FirstOrDefaultAsync();

            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var item = await this.cloverDonutsDbContext.Products.Where(itemId => itemId.Id == id).FirstOrDefaultAsync();

            return item;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.cloverDonutsDbContext.Products.ToListAsync();
            return products;
        }
    }
}
