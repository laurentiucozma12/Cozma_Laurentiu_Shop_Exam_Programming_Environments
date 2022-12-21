using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlanteeaShop.Models;

namespace PlanteeaShop.Data
{
    public class PlanteeaShopContext : DbContext
    {
        public PlanteeaShopContext (DbContextOptions<PlanteeaShopContext> options)
            : base(options)
        {
        }

        public DbSet<PlanteeaShop.Models.Product> Product { get; set; } = default!;
    }
}
