using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryMangement.Data;
using InventoryMangement.Models;

namespace InventoryMangement.Pages.Admin.Products
{
    public class IndexModel : PageModel
    {
        private readonly InventoryMangement.Data.ApplicationDbContext _context;

        public IndexModel(InventoryMangement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
