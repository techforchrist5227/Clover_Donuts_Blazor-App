using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloverDonuts.Models.DTO
{
    /// <summary>
    /// Updates the quantity of the cart items in the cart
    /// </summary>
    public class CartItemQtyUpdateDTO
    {
        public int CartItemId  { get; set; }

        public int Qty { get; set; }
    }
}
