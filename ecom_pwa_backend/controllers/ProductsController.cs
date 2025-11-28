using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecom_pwa_backend.data;
using ecom_pwa_backend.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ecom_pwa_backend.controllers
{
    [ApiController]
    [Route("api/[controller]")] // https://localhost:5001/api/products
    public class ProductsController(StoreContext context) : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            return context.Products.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = context.Products.Find(id);

            if (product == null) return NotFound();

            return product;
        }

    }
}