using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SHoppingCart.Model;
using SHoppingCart.Services;

namespace SHoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IBasketService _iBasketService;
        public ShoppingCartController(IBasketService iBasketService)
        {
            _iBasketService = iBasketService;
        }

        // GET: api/ShoppingCart/GetBasketItems
        [HttpGet("GetBasketItems/{userId}")]
        public async Task<IActionResult> GetBasketItems(int userId)
        {
            List<BasketItem> basketItems = await _iBasketService.GetBasketItemsAsync(userId);
            return Ok(basketItems);
        }


        // POST api/ShoppingCart
        [HttpPost]
        public async Task<IActionResult> AddItemintoBasketAsync(BasketItem basketItem)
        {
            await _iBasketService.AddItemintoBasketAsync(basketItem);
            return Created($"ShoppingCart", basketItem);
        }

        // PUT api/ShoppingCart/ChangeItemQuantity/5/4
        [HttpPut("ChangeItemQuantity/{basketItemId}/{quantity}")]
        public async Task<IActionResult> ChangeItemQuantity(int basketItemId, int quantity)
        {
           BasketItem basketItems = await _iBasketService.ChangeBasketItemQuantityAsync(basketItemId, quantity);
            if (basketItems == null)
                return NotFound("Item not found in the basket, please check the basketItemId");
            return Ok(basketItems);
        }

        // DELETE api/ShoppingCart/ClearBasket/1
        [HttpDelete("ClearBasket/{userId}")]
        public async Task<IActionResult> ClearBasket(int userId)
        {
            string basketItems = await _iBasketService.ClearBasketAsync(userId);
            return Ok(basketItems);
        }

        // DELETE api/ShoppingCart/DeleteItemFromBasket/5
        [HttpDelete("DeleteItemFromBasket/{basketItemId}")]
        public async Task<IActionResult> DeleteItemFromBasket(int basketItemId)
        {
            List<BasketItem> basketItems = await _iBasketService.DeleteBasketItemByIdAsync(basketItemId);
            if (basketItems == null)
                return NotFound("Item not found in the basket, please check the basketItemId");
            return Ok(basketItems);
        }


    }
}
