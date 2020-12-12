using SHoppingCart.Model;
using SHoppingCart.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHoppingCart.Services
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepository _iRepository;
        public BasketService(IBasketRepository iRepository)
        {
            _iRepository = iRepository;
        }

        public async Task<BasketItem> AddItemintoBasketAsync(BasketItem basketItem)
        {
            BasketItem basketItems = await _iRepository.AddItemintoBasketAsync(basketItem);
            //this is for primeray key generate becuase the actuall database is not not connected, once we have actuall db connected the following live of code will be remove
           
            return basketItem;
        }

        public async Task<List<BasketItem>> GetBasketItemsAsync(int userId)
        {
            var basketItems = await _iRepository.GetBasketItemsAsync(userId);
            return basketItems;
        }

        public async Task<string> ClearBasketAsync(int userId)
        {
            return await _iRepository.ClearBasketAsync(userId);
        }

        public async Task<List<BasketItem>> DeleteBasketItemByIdAsync(int id)
        {
           return await _iRepository.DeleteBasketItemByIdAsync(id);
           

        }

        public async Task<BasketItem> ChangeBasketItemQuantityAsync(int id, int quantity)
        {
            return await _iRepository.ChangeBasketItemQuantityAsync(id,quantity);
        }

       

    }
}
