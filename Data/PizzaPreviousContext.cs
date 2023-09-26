using Microsoft.EntityFrameworkCore;
using PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql.EntityFrameworkCore;


namespace PizzaApp.Data
{
    public class PizzaPreviousContext:DbContext
    {
        //public DbSet<Customer> Customers { get; set; } = null;
        //public DbSet<Order> Orders { get; set; } = null;
        //public DbSet<Product> Products { get; set; } = null;
        //public DbSet<OrderDetails> OrderDetails { get; set; } = null;

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseNpgsql("Host=localhost; Port=5433; Database=PizzaDb; Username=postgres; Password=2023");

        //}


    }
}
