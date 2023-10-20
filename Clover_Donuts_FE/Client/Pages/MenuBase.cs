using Clover_Donuts_FE.Client.Services.Contracts;
using CloverDonuts.Models.DTO;
using Microsoft.AspNetCore.Components;

namespace Clover_Donuts_FE.Client.Pages
{
    public class MenuBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductDTO> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }

    }
}
