using HomeImprovementShopCartBlazor.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeImprovementShopCartBlazor.API.Data
{
    public class HomeImprovementShopCartDbContext : DbContext
    {
        public HomeImprovementShopCartDbContext(DbContextOptions<HomeImprovementShopCartDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Products
            //Beauty Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Glossy - Granite",
                Description = "A kitchen provided by Glossy, with Quartz countertop and oak wood",
                ImageURL = "/Images/Kitchen/img1.jpg",
                Price = 100,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Curology - Granit",
                Description = "A kitchen provided by Curology, with Granite countertop and oak wood",
                ImageURL = "/Images/Kitchen/img2.jpg",
                Price = 50,
                Qty = 45,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Cocooil - Quartz",
                Description = " spacious islands are partly to blame for wall units falling out of fashion",
                ImageURL = "/Images/Kitchen/img3.jpg",
                Price = 20,
                Qty = 30,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Schwarzkopf - Open plan kitchens",
                Description = "Popular options include lift up doors and tall, sleek, flat-fronted doors in a striking material",
                ImageURL = "/Images/Kitchen/img4.jpg",
                Price = 50,
                Qty = 60,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Third galley kitchen",
                Description = "Modern galley kitchens can be part of a much larger space, featuring a wall-hugging galley run with a long island running parallel",
                ImageURL = "/Images/Kitchen/img5.jpg",
                Price = 30,
                Qty = 85,
                CategoryId = 1

            });
            //Electronics Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Air Pods",
                Description = "Air Pods - in-ear wireless headphones",
                ImageURL = "/Images/Kitchen/img6.jpg",
                Price = 100,
                Qty = 120,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Declutter The Right Storage",
                Description = "A scheme that includes plenty of storage, and if wall units aren’t possible in all areas",
                ImageURL = "/Images/Kitchen/img7.jpg",
                Price = 40,
                Qty = 200,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Minimal Cabinetry",
                Description = "The trick is to make the space work for you – make it look bigger by using light colors and reflective surfaces",
                ImageURL = "/Images/Kitchen/img8.jpg",
                Price = 40,
                Qty = 300,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Murphy Bed",
                Description = " one of the most intelligent types of bed design as they can be pushed back into the wall when not in use",
                ImageURL = "/Images/Bedroom/img1.jpg",
                Price = 600,
                Qty = 20,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Trundle Bed",
                Description = "ow bed which can be pulled out or rolled out from the parent bed or bed with sliders.",
                ImageURL = "/Images/Bedroom/img2.jpg",
                Price = 500,
                Qty = 15,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Bunk Beds",
                Description = "the most popular choice when thinking of  beds for children’s rooms",
                ImageURL = "/Images/Bedroom/img3.jpg",
                Price = 100,
                Qty = 60,
                CategoryId = 2
            });
            //Furniture Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Hydraulic Beds",
                Description = "This box type bed design has a lift-up mechanism and is built to provide storage beneath",
                ImageURL = "/Images/Bedroom/img4.jpg",
                Price = 50,
                Qty = 212,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Floor Bed",
                Description = "Floor beds are often called futons that are nothing but padded mattresses and are easy to roll up",
                ImageURL = "/Images/Bedroom/img5.jpg",
                Price = 50,
                Qty = 112,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Storage Bed",
                Description = " bed which have storage either to lift up or in the form of drawer type bed.",
                ImageURL = "/Images/Bedroom/img6.jpg",
                Price = 70,
                Qty = 90,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Jack-and-Jill",
                Description = "These bathrooms can feature one or two sinks, and include a tub or shower and a toilet",
                ImageURL = "/Images/Bathroom/img1.jpg",
                Price = 120,
                Qty = 95,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Split/Split Entry",
                Description = "Split bathrooms are ideal in situations where the bathroom has to be shared by more than one person",
                ImageURL = "/Images/Bathroom/img2.jpg",
                Price = 15,
                Qty = 100,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Corner Shower",
                Description = "They feature a shower stall that can either be placed in the corner for the best use of space",
                ImageURL = "/Images/Bathroom/img3.jpg",
                Price = 20,
                Qty = 73,
                CategoryId = 3
            });
            //Shoes Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Accessible Residential",
                Description = "Sufficiently clear floor space so that a wheelchair is able to perform a complete turn",
                ImageURL = "/Images/Bathroom/img4.jpg",
                Price = 100,
                Qty = 50,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Colorful Style",
                Description = "entry area and main or primary sink in one distinct area of the bathroom",
                ImageURL = "/Images/Bathroom/img5.jpg",
                Price = 150,
                Qty = 60,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Blue Nike Style",
                Description = "One might also see this bathroom referred to as the primary bathroom",
                ImageURL = "/Images/Bathroom/img6.jpg",
                Price = 200,
                Qty = 70,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "Three-Quarter",
                Description = "Strategically placed storage shelves, and although still widely considered",
                ImageURL = "/Images/Bathroom/img7.jpg",
                Price = 120,
                Qty = 120,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "Shelving and art",
                Description = "materials that are slip-resistant as well as mold- and mildew-resistant are ideal.",
                ImageURL = "/Images/Bathroom/img8.jpg",
                Price = 200,
                Qty = 100,
                CategoryId = 3
            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Shazia"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Idrees"

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Kitchen",
                IconCSS = "fas fa-sink"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Bedroom",
                IconCSS = "fas fa-bed"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Bathroom",
                IconCSS = "fas fa-restroom"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Shoes",
                IconCSS = "fas fa-shoe-prints"
            });


        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
