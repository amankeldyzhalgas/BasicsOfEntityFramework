// <copyright file="Cart.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BasicsOfEntityFramework.Domain.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// CArt class.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets CustomerId.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets Customer.
        /// </summary>
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets ProductCarts.
        /// </summary>
        public virtual List<ProductCart> ProductCarts { get; set; }
    }
}
