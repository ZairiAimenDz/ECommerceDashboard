using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using InventoryMangement.Models;

namespace InventoryMangement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<InventoryMangement.Models.Product> Product { get; set; }
        public DbSet<InventoryMangement.Models.Customer> Customer { get; set; }
        public DbSet<InventoryMangement.Models.Provider> Provider { get; set; }
    }
}
