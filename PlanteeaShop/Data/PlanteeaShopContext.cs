using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Data
{
    public class PlanteeaShopContext : DbContext
    {
        public PlanteeaShopContext (DbContextOptions<PlanteeaShopContext> options)
            : base(options)
        {
        }

        public DbSet<Shop.Models.Product> Product { get; set; } = default!;

        public DbSet<Shop.Models.Seller> Seller { get; set; }

        public DbSet<Shop.Models.ProductOrigin> ProductOrigin { get; set; }
    }
}
