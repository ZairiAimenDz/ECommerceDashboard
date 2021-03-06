﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InventoryMangement.Data;
using InventoryMangement.Models;

namespace InventoryMangement.Pages.Admin.Products
{
    public class CreateModel : PageModel
    {
        private readonly InventoryMangement.Data.ApplicationDbContext _context;

        public CreateModel(InventoryMangement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Provider> Providers = new List<Provider>();
        public IActionResult OnGet()
        {
            Providers = _context.Provider.ToList();
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }
        [BindProperty]
        public Guid ProviderID { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var prov = _context.Provider.Find(ProviderID);
            if (prov != null)
            {
                prov.Products.Add(Product);
            }
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
