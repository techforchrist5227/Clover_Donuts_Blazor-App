namespace Clover_Donuts_FE.Server.Entities
{
    public class User
    {//one to one relat with cart
        public int Id { get; set; }

        public string UserName { get; set; }

        public bool? IsAdmin { get; set; }

    }
}
