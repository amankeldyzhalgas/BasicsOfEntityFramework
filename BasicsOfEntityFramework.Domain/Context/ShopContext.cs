// <copyright file="ShopContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BasicsOfEntityFramework.Domain.Context
{
    using System;
    using BasicsOfEntityFramework.Domain.Entities;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// .
    /// </summary>
    public class ShopContext : DbContext
    {
        /// <summary>
        /// Gets or sets .
        /// </summary>
        public DbSet<Customer> Customers { get; set; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public DbSet<Seller> Sellers { get; set; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public DbSet<Comment> Comments { get; set; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public DbSet<Cart> Carts { get; set; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public DbSet<ProductCart> ProductCarts { get; set; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public DbSet<ProductOrder> ProductOrders { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopContext"/> class.
        /// </summary>
        public ShopContext()
        {
        }

        /// <summary>
        /// Connection settings.
        /// </summary>
        /// <param name="optionsBuilder">Sets the connection parameters.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(local);Database=onlineshop;Trusted_Connection=True;");
        }

        /// <summary>
        /// Used to initialize the context.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer[]
                {
                    new Customer { Id = 1,  CustomerName = "Tom", Address = "Astana", Email = "tom@gmail.com", Phone = "789321"},
                    new Customer { Id = 2,  CustomerName = "Alice", Address = "Karaganda", Email = "alice@gmail.com", Phone = "159753" },
                });

            modelBuilder.Entity<Seller>().HasData(
                new Seller[]
                {
                    new Seller { Id = 1, SellerName = "Sam", Address = "Almaty", Email = "sam@gmail.com", Phone = "357951"},
                });

            modelBuilder.Entity<Product>().HasData(
                new Product[]
                {
                    new Product { Id = 1, ProductName = "Keyboard", Description = "HP Notebook Keyboard", Quantity = 5, Price = 6000, SellerId = 1 },
                    new Product { Id = 2, ProductName = "Mouse", Description = "Mouse Delux", Quantity = 4, Price = 4000, SellerId = 1 },
                    new Product { Id = 3, ProductName = "Monitor", Description = "Monitor Philips", Quantity = 2, Price = 20000, SellerId = 1 },
                });

            modelBuilder.Entity<Cart>().HasData(
                new Cart[]
                {
                    new Cart { Id = 1,  CustomerId = 1, },
                    new Cart { Id = 2,  CustomerId = 2 },
                });

            modelBuilder.Entity<ProductCart>().HasData(
                new ProductCart[]
                {
                    new ProductCart { Id = 1,  ProductId = 1, CartId = 1, Quantity = 1 },
                    new ProductCart { Id = 2,  ProductId = 1, CartId = 2, Quantity = 1 },
                });

            modelBuilder.Entity<Order>().HasData(
                new Order[]
                {
                    new Order { Id = 1, Number = "Order00001", CustomerId = 1, Date = DateTime.Parse("16.11.2019"), Status = "Available"},
                    new Order { Id = 2, Number = "Order00002", CustomerId = 2, Date = DateTime.Parse("20.11.2019"), Status = "Accepted"},
                });

            modelBuilder.Entity<ProductOrder>().HasData(
                new ProductOrder[]
                {
                    new ProductOrder { Id = 1,  ProductId = 1, OrderId = 1, Quantity = 2},
                    new ProductOrder { Id = 2,  ProductId = 1, OrderId = 2, Quantity = 2 },
                });

            modelBuilder.Entity<Comment>().HasData(
                new Comment[]
                {
                    new Comment { Id = 1, CustomerId = 1, ProductId = 1, Text = "4" },
                    new Comment { Id = 2, CustomerId = 2, ProductId = 1, Text = "4" },
                    new Comment { Id = 3, CustomerId = 2, ProductId = 2, Text = "5" },
                    new Comment { Id = 4, CustomerId = 2, ProductId = 2, Text = "4+" },
                    new Comment { Id = 5, CustomerId = 1, ProductId = 3, Text = "5" },
                });
        }
    }
}
