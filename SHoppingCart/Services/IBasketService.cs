using SHoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHoppingCart.Services
{
    public interface IBasketService
    {
        Task<BasketItem> AddItemintoBasketAsync(BasketItem basketItem);
        Task<BasketItem> ChangeBasketItemQuantityAsync(int id, int quantity);
        Task<string> ClearBasketAsync(int userId);
        Task<List<BasketItem>> DeleteBasketItemByIdAsync(int id);
        Task<List<BasketItem>> GetBasketItemsAsync(int userId);
    }
}
