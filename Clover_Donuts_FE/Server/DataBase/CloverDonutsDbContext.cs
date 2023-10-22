using Clover_Donuts_FE.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clover_Donuts_FE.Server.DataBase
{
    public class CloverDonutsDbContext : DbContext
    {
        public CloverDonutsDbContext(DbContextOptions<CloverDonutsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Products
            //Bakery Category

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Glazed Donut",
                Description = "A sweet and fluffy Donut made from scratch in store. ",
                ImageUrl = "Clover_Donuts_FE/Clover_Donuts_FE/Client/wwwroot/Images/glazed_donut.png",
                Price = 1,
                Quantity = 50,
                CategoryId = 1
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Chocolate Donut",
                Description = "A chocolate Donut made from scratch in store. ",
                ImageUrl = "Clover_Donuts_FE/Clover_Donuts_FE/Client/wwwroot/Images/chocolate_donut.png",
                Price = 1,
                Quantity = 50,
                CategoryId = 2
            });


            //Breakfast Hot Food Category
            modelBuilder.Entity<Product>().HasData(new Product
            {//because this is a continuation of products the ID number will increase because it's still a product entity.
                Id = 3,
                Name = "Ham Egg and Cheese Croissant",
                Description = "Ham egg and cheese on a buttery flaky croissant",
                ImageUrl = "/Images/Breakfast/HECcroissant.png",
                Price = 4,
                Quantity = 10,
                CategoryId = 3

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {//because this is a continuation of products the ID number will increase because it's still a product entity.
                Id = 4,
                Name = "Bacon Egg and Cheese Croissant",
                Description = "Bacon egg and cheese on a buttery flaky croissant",
                ImageUrl = "/Images/Breakfast/BECcroissant.png",
                Price = 4,
                Quantity = 8,
                CategoryId = 4

            });

            //Deli Subs Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Ham Sub",
                Description = "A deli style ham sub with fresh ingredients",
                ImageUrl = "/Images/Subs/HamSub.png",
                Price = 5,
                Quantity = 6,
                CategoryId = 5
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Italian Sub",
                Description = "A deli style italian sub with fresh ingredients",
                ImageUrl = "/Images/Subs/ItalianSub.png",
                Price = 5,
                Quantity = 6,
                CategoryId = 6
            });

            
            //Frappes Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Mocha Frappe",
                Description = "Delicious creamy mocha frappe blended in store",
                ImageUrl = "/Images/Shoes/Shoes1.png",
                Price = 5,
                Quantity = 10,
                CategoryId = 7
            });
            

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Brett",
                IsAdmin = true,

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Simna",
                IsAdmin = true,

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserID = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserID = 2

            });
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Donuts"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Breakfast"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Deli Subs"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Frappes"
            });
        }

        //let ef core know about our entities

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<Product> Products { get; set; }


    }
}
