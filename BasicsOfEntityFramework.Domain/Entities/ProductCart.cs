// <copyright file="ProductCart.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BasicsOfEntityFramework.Domain.Entities
{
    /// <summary>
    /// ProductCart class.
    /// </summary>
    public class ProductCart
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets ProductId.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets Product.
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// Gets or sets CartId.
        /// </summary>
        public int CartId { get; set; }

        /// <summary>
        /// Gets or sets Cart.
        /// </summary>
        public virtual Cart Cart { get; set; }
    }
}
