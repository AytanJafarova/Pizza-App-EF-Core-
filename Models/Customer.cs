using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; } = null;
        public string Lastname { get; set; } = null;
        public string? Addresss { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
