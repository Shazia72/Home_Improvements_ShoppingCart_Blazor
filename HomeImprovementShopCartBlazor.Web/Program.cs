using Blazored.LocalStorage;
using HomeImprovementShopCartBlazor.Web.Services;
using HomeImprovementShopCartBlazor.Web.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace HomeImprovementShopCartBlazor.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7111") });

            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();

            builder.Services.AddBlazoredLocalStorage();

            builder.Services.AddScoped<IManageProductsLocalStorageService, ManageProductsLocalStorageService>();
            builder.Services.AddScoped<IManageCartItemsLocalStorageService, ManageCartItemsLocalStorageService>();

            await builder.Build().RunAsync();
        }
    }
}
