namespace Clover_Donuts_FE.Server.Entities
{
    public class Cart
    {
        //primary key for the shopping cart itself, has a 1 to many relationship with the cart item entity
        public int Id { get; set; }

        //Each user will have their own shopping cart and it will be only accessible by that single user
        public int UserID { get; set; }

    }
}
