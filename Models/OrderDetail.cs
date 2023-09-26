using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Models
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public Order Order { get; set; } = null;
        public Product Product { get; set; } = null;

    }
}
