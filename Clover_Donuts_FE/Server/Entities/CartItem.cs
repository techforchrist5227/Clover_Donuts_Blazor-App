namespace Clover_Donuts_FE.Server.Entities
{
    public class CartItem
    {
        //this is the primary key related to the shopping cart itself
        public int Id { get; set; }

        //this is a foreign key that will join the cart items to the shopping cart
        public int CartId { get; set; }

        public string? Name { get; set; }

        public int ProductId { get; set; }

        public string? Description { get; set; }

        public int Quantity { get; set; }

    }
}
