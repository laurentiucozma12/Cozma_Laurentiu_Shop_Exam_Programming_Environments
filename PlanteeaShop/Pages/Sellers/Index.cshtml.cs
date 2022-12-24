using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;

namespace Shop.Pages.Sellers
{
    public class IndexModel : PageModel
    {
        private readonly Shop.Data.PlanteeaShopContext _context;

        public IndexModel(Shop.Data.PlanteeaShopContext context)
        {
            _context = context;
        }

        public IList<Seller> Seller { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Seller != null)
            {
                Seller = await _context.Seller.ToListAsync();
            }
        }
    }
}
