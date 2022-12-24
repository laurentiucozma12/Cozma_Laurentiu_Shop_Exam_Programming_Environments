using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Data;
using Shop.Models;

namespace Shop.Pages.ProductOrigins
{
    public class CreateModel : PageModel
    {
        private readonly Shop.Data.PlanteeaShopContext _context;

        public CreateModel(Shop.Data.PlanteeaShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ProductOrigin ProductOrigin { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProductOrigin.Add(ProductOrigin);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
