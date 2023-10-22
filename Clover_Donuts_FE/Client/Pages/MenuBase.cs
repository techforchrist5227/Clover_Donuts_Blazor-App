using Clover_Donuts_FE.Client.Services.Contracts;
using CloverDonuts.Models.DTO;
using Microsoft.AspNetCore.Components;

namespace Clover_Donuts_FE.Client.Pages
{
    public class MenuBase : ComponentBase
    {
        //using the IProductService function "GetItems()" to obtain the items from the DB
        [Inject]
        public IProductService? ProductService { get; set; }
        

        public IEnumerable<ProductDTO> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }

    }
}
