using Clover_Donuts_FE.Client.Services.Contracts;
using CloverDonuts.Models.DTO;
using System.Net.Http.Json;

namespace Clover_Donuts_FE.Client.Services
{/// <summary>
/// A product service class that will retrieve product data to be displayed to the client side. 
/// </summary>
    public class ProductService : IProductService
    {
        // private member variable for HTTPClient that will reach out to the api
        private readonly HttpClient httpClient;

        //constructor so you can use the httpClient service
        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;

        }
        

        // method a.k.a function that reaches out to ProductDTO model to get the donuts
        public async Task<IEnumerable<ProductDTO>> GetItems()
        { //reaches out to the api and does a get request to the api/product uri to retrieve the products.  Translates json to correct format after
            try
            {
                var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDTO>>("api/product");

                return products;

                
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
