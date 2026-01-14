using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecom_pwa_backend.Entities.OrderAggregate;

namespace ecom_pwa_backend.DTOs
{
    public class CreateOrderDto
    {
        public required ShippingAddress ShippingAddress { get; set; }

        public required PaymentSummary PaymentSummary { get; set; }
    }
}