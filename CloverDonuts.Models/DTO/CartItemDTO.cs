using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloverDonuts.Models.DTO
{
    public class CartItemDTO
    {
        //Primary Key 
        public int Id{ get; set; }

        public int ProductId{ get; set; }

        public int CartId { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set;}

        public string ProductImageUrl { get; set; }

        public decimal Price { get; set; }

        public decimal PriceTotal { get; set;}

        public int Quantity { get; set; }

    }
}
