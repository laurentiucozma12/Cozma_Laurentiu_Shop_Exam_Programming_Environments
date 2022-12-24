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
    public class DetailsModel : PageModel
    {
        private readonly Shop.Data.PlanteeaShopContext _context;

        public DetailsModel(Shop.Data.PlanteeaShopContext context)
        {
            _context = context;
        }

      public Seller Seller { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Seller == null)
            {
                return NotFound();
            }

            var seller = await _context.Seller.FirstOrDefaultAsync(m => m.ID == id);
            if (seller == null)
            {
                return NotFound();
            }
            else 
            {
                Seller = seller;
            }
            return Page();
        }
    }
}
