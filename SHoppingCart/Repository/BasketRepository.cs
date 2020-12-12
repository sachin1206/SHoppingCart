using SHoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHoppingCart.Repository
{
    public class BasketRepository : IBasketRepository
    {
        private List<BasketItem> basketItemList = new List<BasketItem>() {
            new BasketItem(){Id =122,Quantity=2,ProductId =122,Product = new Product{Id =121, Desciption= "Cisco Aironet", Name =" Tablet", Price ="$23",Avaiablity ="Instock" },UserId = 101 },
            new BasketItem(){Id =123,Quantity=1,ProductId =123,Product = new Product{Id =123, Desciption= "Samsung Phone", Name =" Watch", Price ="$23",Avaiablity ="Instock"},UserId =102 }
        };

        public Task<BasketItem> AddItemintoBasketAsync(BasketItem basketItem)
        {
            if(basketItem != null)
            {
                basketItemList.Add(basketItem);
            }

            return Task.Run(()=> basketItem);
        }

        public Task<BasketItem> ChangeBasketItemQuantityAsync(int id, int quantity)
        {
            if(id != 0)
            {
              var items=  basketItemList.Where(x => x.Id == id).ToList();
                items[0].Quantity = quantity;
            }

            return Task.Run(() => basketItemList.Where(r => r.Id == id).FirstOrDefault());
        }

        public Task<string> ClearBasketAsync(int userId)
        {
            basketItemList.Select(x=>x.UserId==userId).ToList().Clear();

            if(basketItemList == null)
            {
                return Task.Run(() => "Removed");
            }
            return Task.Run(() => "Invalid");
        }

        public Task<List<BasketItem>> DeleteBasketItemByIdAsync(int id)
        {
            var itemToRemove = basketItemList.Single(r => r.Id == id);
            basketItemList.Remove(itemToRemove);
            return Task.Run(() => basketItemList);
        }

        public Task<List<BasketItem>> GetBasketItemsAsync(int userId)
        {
            return Task.Run(() => basketItemList.Where(x => x.UserId == userId).ToList());
        }
    }
}
