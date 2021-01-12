using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryMangement.Models
{
    public class Customer
    {
        public Guid ID { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public string Adress { get; set; }
        [Required]
        public string ShipAdress { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
