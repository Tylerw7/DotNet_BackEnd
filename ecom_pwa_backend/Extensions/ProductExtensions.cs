using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecom_pwa_backend.Entities;

namespace ecom_pwa_backend.Extensions
{
    public static class ProductExtensions
    {
        public static IQueryable<Product> Sort(this IQueryable<Product> query, string? orderBy)
        {
            query = orderBy switch
            {
                "price" => query.OrderBy(x => x.Price),
                "priceDesc" => query.OrderByDescending(x => x.Price),
                _ => query.OrderBy(x => x.Name)
            };

            return query;
        }

        public static IQueryable<Product> Search(this IQueryable<Product> query, string? searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm)) return query;

            var lowerCaseSearchTerm = searchTerm.Trim().ToLower();

            return query.Where(x => x.Name.ToLower().Contains(lowerCaseSearchTerm));
            
        }
    }
}