using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime OrderFullFilled { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
