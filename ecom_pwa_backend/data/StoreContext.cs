using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecom_pwa_backend.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ecom_pwa_backend.data
{
    public class StoreContext(DbContextOptions options) : IdentityDbContext<User>(options)
    {
        public required DbSet<Product> Products { get; set; }

        public required DbSet<Basket> Baskets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole {Id = "2d2b0ca6-90af-4f88-8c18-9f0146a802e7", Name = "Member", NormalizedName = "MEMBER" },
                    new IdentityRole {Id = "7b0e7f5f-55cb-44d3-9a5d-bcc20e0c176c", Name = "Admin", NormalizedName = "ADMIN" }
                );
        }

    }
}