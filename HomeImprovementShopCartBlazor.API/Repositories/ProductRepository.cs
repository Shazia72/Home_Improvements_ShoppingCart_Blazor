using HomeImprovementShopCartBlazor.API.Data;
using HomeImprovementShopCartBlazor.API.Entities;
using HomeImprovementShopCartBlazor.API.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace HomeImprovementShopCartBlazor.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly HomeImprovementShopCartDbContext homeImprovementShopCartDbContext;

        public ProductRepository(HomeImprovementShopCartDbContext homeImprovementShopCartDbContext)
        {
            this.homeImprovementShopCartDbContext = homeImprovementShopCartDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.homeImprovementShopCartDbContext.ProductCategories.ToListAsync();

            return categories;

        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category = await homeImprovementShopCartDbContext.ProductCategories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await homeImprovementShopCartDbContext.Products
                                .Include(p => p.ProductCategory)
                                .SingleOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.homeImprovementShopCartDbContext.Products
                                     .Include(p => p.ProductCategory).ToListAsync();

            return products;

        }

        public async Task<IEnumerable<Product>> GetItemsByCategory(int id)
        {
            var products = await this.homeImprovementShopCartDbContext.Products
                                     .Include(p => p.ProductCategory)
                                     .Where(p => p.CategoryId == id).ToListAsync();
            return products;
        }
    }
}
