// <copyright file="ProductOrder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BasicsOfEntityFramework.Domain.Entities
{
    /// <summary>
    /// ProductOrder class.
    /// </summary>
    public class ProductOrder
    {
        /// <summary>
        /// Gets or sets .
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public virtual Order Order { get; set; }
    }
}
