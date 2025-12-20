using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecom_pwa_backend.DTOs;
using ecom_pwa_backend.Entities;

namespace ecom_pwa_backend.Extensions
{
    public static class BasketExtensions
    {
        public static BasketDtos ToDto(this Basket basket) // Basket.ToDto()
        {
            return new BasketDtos
            {
                BasketId = basket.BasketId,
                Items = basket.Items.Select(x => new BasketItemDto
                {
                    ProductId = x.ProductId,
                    Name = x.Product.Name,
                    Price = x.Product.Price,
                    Brand = x.Product.Brand,
                    Type = x.Product.Type,
                    PictureUrl = x.Product.PictureUrl,
                    Quantity = x.Quantity
                }).ToList()
            };
        }
    }
}