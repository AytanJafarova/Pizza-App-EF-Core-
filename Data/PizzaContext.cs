using Microsoft.EntityFrameworkCore;
using PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace PizzaApp.Data
{
    public class PizzaContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null;
        public DbSet<Order> Orders { get; set; } = null;
        public DbSet<Product> Product { get; set; } = null;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Host=localhost; Port=5433; Database=LinkedInDb; Username=postgres; Password=2023");
        }

    }
}
