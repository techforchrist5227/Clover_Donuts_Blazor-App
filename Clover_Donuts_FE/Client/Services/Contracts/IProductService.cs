using CloverDonuts.Models.DTO;

namespace Clover_Donuts_FE.Client.Services.Contracts
{
    public interface IProductService
    {//build up methods for the product services.  It's an interface that allows for cleaner architecture and ensures that all methods are used. 

        Task<IEnumerable<ProductDTO>> GetItems();


        
        
    }
}
