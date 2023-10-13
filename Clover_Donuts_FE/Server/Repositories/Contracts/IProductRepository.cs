using Clover_Donuts_FE.Server.Entities;


namespace Clover_Donuts_FE.Server.Repositories.Contracts
{
    /// <summary>
    /// This is an interface for the repositories
    /// </summary>
    public interface IProductRepository
    { // These are going to run asynchronously so we are going to use Task<IEnumerable>
        Task<IEnumerable<Product>> GetItems();

        Task<IEnumerable<ProductCategories>> GetCategories();
        //Gets a single Item by Id
        Task<Product> GetItem(int id);

        Task<ProductCategory> GetCategory(int id);


    }
}
