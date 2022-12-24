using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Data;
using Shop.Models;

namespace Shop.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly Shop.Data.ShopContext _context;

        public CreateModel(Shop.Data.ShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["SellerID"] = new SelectList(_context.Set<Seller>(), "ID", "SellerName");
            ViewData["ProductOriginID"] = new SelectList(_context.Set<ProductOrigin>(), "ID", "OriginName");

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
