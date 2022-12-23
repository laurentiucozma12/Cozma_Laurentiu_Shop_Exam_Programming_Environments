using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PlanteeaShop.Data;
using PlanteeaShop.Models;

namespace PlanteeaShop.Pages.ProductOrigins
{
    public class IndexModel : PageModel
    {
        private readonly PlanteeaShop.Data.PlanteeaShopContext _context;

        public IndexModel(PlanteeaShop.Data.PlanteeaShopContext context)
        {
            _context = context;
        }

        public IList<ProductOrigin> ProductOrigin { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ProductOrigin != null)
            {
                ProductOrigin = await _context.ProductOrigin.ToListAsync();
            }
        }
    }
}
