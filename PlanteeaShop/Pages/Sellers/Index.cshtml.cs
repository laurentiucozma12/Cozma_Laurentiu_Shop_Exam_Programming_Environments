using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PlanteeaShop.Data;
using PlanteeaShop.Models;

namespace PlanteeaShop.Pages.Sellers
{
    public class IndexModel : PageModel
    {
        private readonly PlanteeaShop.Data.PlanteeaShopContext _context;

        public IndexModel(PlanteeaShop.Data.PlanteeaShopContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Product != null)
            {
                Product = await _context.Product
                .Include(p => p.Seller).ToListAsync();
            }
        }
    }
}
