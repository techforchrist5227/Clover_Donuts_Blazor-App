using System.ComponentModel.DataAnnotations.Schema;

namespace Clover_Donuts_FE.Server.Entities
{
    //one to many relationship with the shopping cart
    public class Product
    {
        //this is the primary key related to the product itself
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl{ get; set; }

        public decimal ? Price { get; set; }

        public int Quantity { get; set; }

        public int CategoryId { get; set; }


        [ForeignKey("CategoryId")]
        public ProductCategory ProductCategories { get; set; } = new ProductCategory();
    }
}
