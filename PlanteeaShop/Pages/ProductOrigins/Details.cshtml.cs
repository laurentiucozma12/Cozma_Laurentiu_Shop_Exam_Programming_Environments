﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;

namespace Shop.Pages.ProductOrigins
{
    public class DetailsModel : PageModel
    {
        private readonly Shop.Data.ShopContext _context;

        public DetailsModel(Shop.Data.ShopContext context)
        {
            _context = context;
        }

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
    }
}
