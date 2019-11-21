// <copyright file="Customer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BasicsOfEntityFramework.Domain.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// Customer class.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int Id { get; set; }

        // public string Login { get; set; }

        /// <summary>
        /// Gets or sets CustomerName.
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets Phone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Cart.
        /// </summary>
        public virtual Cart Cart { get; set; }

        /// <summary>
        /// Gets or sets Comments.
        /// </summary>
        public virtual List<Comment> Comments { get; set; }

        /// <summary>
        /// Gets or sets Orders.
        /// </summary>
        public virtual List<Order> Orders { get; set; }
    }
}
