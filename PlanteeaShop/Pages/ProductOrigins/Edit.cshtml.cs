using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;

namespace Shop.Pages.ProductOrigins
{
    public class EditModel : PageModel
    {
        private readonly Shop.Data.PlanteeaShopContext _context;

        public EditModel(Shop.Data.PlanteeaShopContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProductOrigin ProductOrigin { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ProductOrigin == null)
            {
                return NotFound();
            }

            var productorigin =  await _context.ProductOrigin.FirstOrDefaultAsync(m => m.ID == id);
            if (productorigin == null)
            {
                return NotFound();
            }
            ProductOrigin = productorigin;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ProductOrigin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductOriginExists(ProductOrigin.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProductOriginExists(int id)
        {
          return _context.ProductOrigin.Any(e => e.ID == id);
        }
    }
}
