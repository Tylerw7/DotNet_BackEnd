using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecom_pwa_backend.Entities
{
    public class BasketItem
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        // navigation properties
        public int ProductId { get; set; }

        public required Product Product { get; set; }
    }
}