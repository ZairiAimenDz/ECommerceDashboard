﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryMangement.Data;
using InventoryMangement.Models;

namespace InventoryMangement.Pages.Admin.Customers
{
    public class IndexModel : PageModel
    {
        private readonly InventoryMangement.Data.ApplicationDbContext _context;

        public IndexModel(InventoryMangement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
