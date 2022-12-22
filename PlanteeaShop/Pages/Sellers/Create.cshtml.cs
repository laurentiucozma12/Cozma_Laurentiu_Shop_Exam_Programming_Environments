using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlanteeaShop.Data;
using PlanteeaShop.Models;

namespace PlanteeaShop.Pages.Sellers
{
    public class CreateModel : PageModel
    {
        private readonly PlanteeaShop.Data.PlanteeaShopContext _context;

        public CreateModel(PlanteeaShop.Data.PlanteeaShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SellerID"] = new SelectList(_context.Set<Seller>(), "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
