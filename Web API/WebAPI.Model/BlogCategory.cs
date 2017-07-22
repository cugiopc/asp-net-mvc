// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlogCategory.cs" company="HAVA">
//   Copyright (c) HAVA, 2017
//   All rights are reserved. Reproduction or transmission in whole or in part, in
//   any form or by any means, electronic, mechanical or otherwise, is prohibited
//   without the prior written consent of the copyright owner.
// </copyright>
// <summary>
//   Defines the BlogCategory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace WebAPI.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class BlogCategory
    {
        /// <summary>
        /// Gets or sets the blog category identifier.
        /// </summary>
        /// <value>
        /// The blog category identifier.
        /// </value>
        public int BlogCategoryId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [MaxLength(150)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the brief description.
        /// </summary>
        /// <value>
        /// The brief description.
        /// </value>
        [MaxLength(300)]
        public string BriefDescription { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the parent blog category identifier.
        /// </summary>
        /// <value>
        /// The parent blog category identifier.
        /// </value>
        public int? ParentBlogCategoryId { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>
        /// The order.
        /// </value>
        public int Order { get; set; }
    }
}