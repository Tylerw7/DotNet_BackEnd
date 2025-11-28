using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecom_pwa_backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace ecom_pwa_backend.data
{
    public class StoreContext(DbContextOptions options) : DbContext(options)
    {
        public required DbSet<Product> Products { get; set; }
    }
}