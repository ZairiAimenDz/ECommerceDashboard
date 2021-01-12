using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryMangement.Models
{
    public class Provider
    {
        public Guid ID { get; set; }
        [Required]
        public string ProviderName { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        public virtual List<Product> Products { get; set; } = new List<Product>();
    }
}
