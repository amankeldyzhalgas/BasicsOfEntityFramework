﻿// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BasicsOfEntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BasicsOfEntityFramework.Domain.Context;
    using BasicsOfEntityFramework.Domain.Entities;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Program class.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method.
        /// </summary>
        /// <param name="args">Args.</param>
        private static void Main(string[] args)
        {
            using (ShopContext db = new ShopContext())
            {
                db.Database.Migrate();
                var orders = db.Orders.Include(o => o.Customer).Where(o => o.Customer == db.Customers.First());
                if (orders != null)
                {
                    Console.WriteLine($"{db.Customers.First().CustomerName} orders:");
                    foreach (var order in orders)
                    {
                        Console.WriteLine($"\t-Order #{order.Number} - {order.Date.ToShortDateString()}");
                    }
                }

                var products = db.Products.Where(p => p.Comments != null).Where(p => p.Comments.Any(c => c.Customer == db.Customers.Last()));
                if (products != null)
                {
                    Console.WriteLine($"{db.Customers.Last().CustomerName} commented products:");
                    foreach (var product in products)
                    {
                        Console.WriteLine($"\t-Product: {product.ProductName}\t Price: {product.Price}");
                    }
                }

                Console.WriteLine("-------------------------Orders------------------------------");
                foreach (var order in db.Orders.Include(o => o.Customer).Include(o => o.ProductOrders).ThenInclude(p => p.Product).ToList())
                {
                    Console.WriteLine($"Order №:{order.Number}\t Customer:{order.Customer.CustomerName}\t Status:{order.Status}");
                    foreach (var product in order.ProductOrders)
                    {
                        Console.WriteLine($"\t-Product: {product.Product.ProductName}\t Quantity: {product.Quantity}");
                    }
                }

                Console.WriteLine("-------------------------Carts------------------------------");
                foreach (var order in db.Carts.Include(c => c.Customer).Include(c => c.ProductCarts).ThenInclude(p => p.Product).ToList())
                {
                    Console.WriteLine($"Customer:{order.Customer.CustomerName}");
                    foreach (var product in order.ProductCarts)
                    {
                        Console.WriteLine($"\t-Product: {product.Product.ProductName}\t Quantity: {product.Quantity}");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
