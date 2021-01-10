using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryMangement.Models
{
    public class Product
    {
        public Guid ID { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public string Title { get; set; }
        public string Info { get; set; }
        public string Brand { get; set; }
        [Required]
        public int Condition { get; set; }
        public string Color { get; set; }
        [Required]
        public int OnStock { get; set; }
        public string Location { get; set; }
        [Required]
        public double Price { get; set; }

    }

}
