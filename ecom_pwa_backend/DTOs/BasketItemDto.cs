using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecom_pwa_backend.DTOs
{
    public class BasketItemDto
    {
        public int ProductId { get; set; }
        public required string Name { get; set; }
        public long Price { get; set; }
        public required  string PictureUrl { get; set; }
        public required  string Brand { get; set; }
        public required  string Type { get; set; }
        public int Quantity { get; set; }

    
    }
}