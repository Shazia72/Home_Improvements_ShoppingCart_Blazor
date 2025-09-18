using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeImprovementShopCartBlazor.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "IconCSS", "Name" },
                values: new object[,]
                {
                    { 1, "fas fa-sink", "Kitchen" },
                    { 2, "fas fa-bed", "Bedroom" },
                    { 3, "fas fa-restroom", "Bathroom" },
                    { 4, "fas fa-shoe-prints", "Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Shazia" },
                    { 2, "Idrees" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, 1, "A kitchen provided by Glossy, with Quartz countertop and oak wood", "/Images/Kitchen/img1.jpg", "Glossy - Granite", 100m, 100 },
                    { 2, 1, "A kitchen provided by Curology, with Granite countertop and oak wood", "/Images/Kitchen/img2.jpg", "Curology - Granit", 50m, 45 },
                    { 3, 1, " spacious islands are partly to blame for wall units falling out of fashion", "/Images/Kitchen/img3.jpg", "Cocooil - Quartz", 20m, 30 },
                    { 4, 1, "Popular options include lift up doors and tall, sleek, flat-fronted doors in a striking material", "/Images/Kitchen/img4.jpg", "Schwarzkopf - Open plan kitchens", 50m, 60 },
                    { 5, 1, "Modern galley kitchens can be part of a much larger space, featuring a wall-hugging galley run with a long island running parallel", "/Images/Kitchen/img5.jpg", "Third galley kitchen", 30m, 85 },
                    { 6, 1, "Air Pods - in-ear wireless headphones", "/Images/Kitchen/img6.jpg", "Air Pods", 100m, 120 },
                    { 7, 1, "A scheme that includes plenty of storage, and if wall units aren’t possible in all areas", "/Images/Kitchen/img7.jpg", "Declutter The Right Storage", 40m, 200 },
                    { 8, 1, "The trick is to make the space work for you – make it look bigger by using light colors and reflective surfaces", "/Images/Kitchen/img8.jpg", "Minimal Cabinetry", 40m, 300 },
                    { 9, 2, " one of the most intelligent types of bed design as they can be pushed back into the wall when not in use", "/Images/Bedroom/img1.jpg", "Murphy Bed", 600m, 20 },
                    { 10, 2, "ow bed which can be pulled out or rolled out from the parent bed or bed with sliders.", "/Images/Bedroom/img2.jpg", "Trundle Bed", 500m, 15 },
                    { 11, 2, "the most popular choice when thinking of  beds for children’s rooms", "/Images/Bedroom/img3.jpg", "Bunk Beds", 100m, 60 },
                    { 12, 2, "This box type bed design has a lift-up mechanism and is built to provide storage beneath", "/Images/Bedroom/img4.jpg", "Hydraulic Beds", 50m, 212 },
                    { 13, 2, "Floor beds are often called futons that are nothing but padded mattresses and are easy to roll up", "/Images/Bedroom/img5.jpg", "Floor Bed", 50m, 112 },
                    { 14, 2, " bed which have storage either to lift up or in the form of drawer type bed.", "/Images/Bedroom/img6.jpg", "Storage Bed", 70m, 90 },
                    { 15, 3, "These bathrooms can feature one or two sinks, and include a tub or shower and a toilet", "/Images/Bathroom/img1.jpg", "Jack-and-Jill", 120m, 95 },
                    { 16, 3, "Split bathrooms are ideal in situations where the bathroom has to be shared by more than one person", "/Images/Bathroom/img2.jpg", "Split/Split Entry", 15m, 100 },
                    { 17, 3, "They feature a shower stall that can either be placed in the corner for the best use of space", "/Images/Bathroom/img3.jpg", "Corner Shower", 20m, 73 },
                    { 18, 3, "Sufficiently clear floor space so that a wheelchair is able to perform a complete turn", "/Images/Bathroom/img4.jpg", "Accessible Residential", 100m, 50 },
                    { 19, 3, "entry area and main or primary sink in one distinct area of the bathroom", "/Images/Bathroom/img5.jpg", "Colorful Style", 150m, 60 },
                    { 20, 3, "One might also see this bathroom referred to as the primary bathroom", "/Images/Bathroom/img6.jpg", "Blue Nike Style", 200m, 70 },
                    { 21, 3, "Strategically placed storage shelves, and although still widely considered", "/Images/Bathroom/img7.jpg", "Three-Quarter", 120m, 120 },
                    { 22, 3, "materials that are slip-resistant as well as mold- and mildew-resistant are ideal.", "/Images/Bathroom/img8.jpg", "Shelving and art", 200m, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
