using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecom_pwa_backend.data;
using ecom_pwa_backend.DTOs;
using ecom_pwa_backend.Entities;
using ecom_pwa_backend.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ecom_pwa_backend.controllers
{
    public class BasketController(StoreContext context) : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<BasketDtos>> GetBasket()
        {
            var basket = await RetrieveBasket();

            if (basket == null) return NoContent();

            return basket.ToDto();
        }

        [HttpPost]
        public async Task<ActionResult<BasketDtos>> AddItemToBasket(int productId, int quantity)
        {
            // get basket
            var basket = await RetrieveBasket();

            //create basket if none exists
            basket ??= CreateBasket();

            // get product
            var product = await context.Products.FindAsync(productId);

            if (product == null) return BadRequest("Problem adding item to basket");

            // add item to basket
            basket.AddItem(product, quantity);

            // save changes
            var result = await context.SaveChangesAsync() > 0;

            if (result) return CreatedAtAction(nameof(GetBasket), basket.ToDto());



            return BadRequest("Problem updating basket");
        }


        [HttpDelete]
        public async Task<ActionResult> RemoveBasketItem(int productId, int quantity)
        {
            // get basket 
            var basket = await RetrieveBasket();

            if (basket == null) return BadRequest("Unable to retrieve basket");

            // remove the item

            basket.RemoveItem(productId, quantity);

            //save changes
            var result = await context.SaveChangesAsync() > 0;

            if (result) return Ok();

            return BadRequest("Problem updating basket");
        }



        private async Task<Basket?> RetrieveBasket()
        {
            return await context.Baskets
                .Include(x => x.Items)
                .ThenInclude(x => x.Product)
                .FirstOrDefaultAsync(x => x.BasketId == Request.Cookies["basketId"]);
        }

        private Basket CreateBasket()
        {
            var basketId = Guid.NewGuid().ToString();
            var cookieOptions = new CookieOptions
            {
                IsEssential = true,
                Expires = DateTime.UtcNow.AddDays(30)
            };

            Response.Cookies.Append("BasketId", basketId, cookieOptions);
            var basket = new Basket { BasketId = basketId };
            context.Baskets.Add(basket);
            return basket;
        }
    }
}