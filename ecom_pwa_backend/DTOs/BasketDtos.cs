using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecom_pwa_backend.DTOs
{
    public class BasketDtos
    {

        public required string BasketId { get; set; }

        public List<BasketItemDto> Items { get; set; } = [];

        public string? ClientSecret { get; set; }

        public string? PaymentIntentId { get; set; }
    }

}