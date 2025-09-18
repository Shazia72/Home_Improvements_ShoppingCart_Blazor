using HomeImprovementShopCartBlazor.Models.Dtos;

namespace HomeImprovementShopCartBlazor.Web.Services.Contracts
{
    public interface IManageProductsLocalStorageService
    {
        Task<IEnumerable<ProductDto>> GetCollection();
        Task RemoveCollection();
    }
}
