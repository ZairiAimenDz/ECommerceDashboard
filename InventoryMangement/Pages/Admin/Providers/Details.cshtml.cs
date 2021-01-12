using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryMangement.Data;
using InventoryMangement.Models;

namespace InventoryMangement.Pages.Admin.Providers
{
    public class DetailsModel : PageModel
    {
        private readonly InventoryMangement.Data.ApplicationDbContext _context;

        public DetailsModel(InventoryMangement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Provider Provider { get; set; }
        public List<Product> Products { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Provider = await _context.Provider.FirstOrDefaultAsync(m => m.ID == id);
            Products = await _context.Product.Where(p => p.Provider == Provider).ToListAsync();

            if (Provider == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
