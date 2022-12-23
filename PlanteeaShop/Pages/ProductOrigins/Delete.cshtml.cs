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
    public class DeleteModel : PageModel
    {
        private readonly PlanteeaShop.Data.PlanteeaShopContext _context;

        public DeleteModel(PlanteeaShop.Data.PlanteeaShopContext context)
        {
            _context = context;
        }

        [BindProperty]
      public ProductOrigin ProductOrigin { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ProductOrigin == null)
            {
                return NotFound();
            }

            var productorigin = await _context.ProductOrigin.FirstOrDefaultAsync(m => m.ID == id);

            if (productorigin == null)
            {
                return NotFound();
            }
            else 
            {
                ProductOrigin = productorigin;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.ProductOrigin == null)
            {
                return NotFound();
            }
            var productorigin = await _context.ProductOrigin.FindAsync(id);

            if (productorigin != null)
            {
                ProductOrigin = productorigin;
                _context.ProductOrigin.Remove(ProductOrigin);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
