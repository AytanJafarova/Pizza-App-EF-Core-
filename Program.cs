using System;
using PizzaApp.Data;
using PizzaApp.Models;


class TestClass
{
    static void Main(string[] args)
    {
        PizzaPreviousContext context = new PizzaPreviousContext();

                                                                                /* Insert */
        //Product veggie = new Product()
        //{
        //    Name = "Veggie Special Pizza",
        //    Price = 9.99M,
        //};
        //Product deluxe = new Product()
        //{
        //    Name = "Deluxe Meat Pizza",
        //    Price = 12.9M
        //};
        //context.Add(veggie);
        //context.Add(deluxe);
        //context.SaveChanges();  

                                                                                 /* Select */

        //var products = from product in context.Products
        //              //where product.Price > 10.00M
        //              orderby product.Name
        //              select product;

        //foreach (Product p in products)
        //{
        //    Console.WriteLine($"ID: {p.ID}");
        //    Console.WriteLine($"Name: {p.Name}");
        //    Console.WriteLine($"Price: {p.Price}");
        //    Console.WriteLine(new string('-',20));
        //}

        //                                                                         /* Update */


        //var veggieSpecial = context.Products.Where(p => p.Name == "Veggie Special Pizza").FirstOrDefault();
        //if ( veggieSpecial is Product )
        //{
        //    veggieSpecial.Name = "New Taste Veggie";
        //}
        //context.SaveChanges();


                                                                                   /* Delete */
        //var veggieSpecial = context.Products.Where(p => p.Name == "New Taste Veggie").FirstOrDefault();
        //if (veggieSpecial is Product)
        //{
        //    context.Remove(veggieSpecial);
        //}
        //context.SaveChanges();






    }
}