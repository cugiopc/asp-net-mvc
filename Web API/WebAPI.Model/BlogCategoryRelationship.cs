// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlogCategoryRelationship.cs" company="HAVA">
//   Copyright (c) HAVA, 2017
//   All rights are reserved. Reproduction or transmission in whole or in part, in
//   any form or by any means, electronic, mechanical or otherwise, is prohibited
//   without the prior written consent of the copyright owner.
// </copyright>
// <summary>
//   Defines the BlogCategoryRelationship type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Model
{
    public class BlogCategoryRelationship
    {
        /// <summary>
        /// Gets or sets the blog category relationship identifier.
        /// </summary>
        /// <value>
        /// The blog category relationship identifier.
        /// </value>
        public int BlogCategoryRelationshipId { get; set; }

        /// <summary>
        /// Gets or sets the blog identifier.
        /// </summary>
        /// <value>
        /// The blog identifier.
        /// </value>
        public int BlogId { get; set; }

        /// <summary>
        /// Gets or sets the blog category identifier.
        /// </summary>
        /// <value>
        /// The blog category identifier.
        /// </value>
        public int BlogCategoryId { get; set; }

        /// <summary>
        /// Gets or sets the blog.
        /// </summary>
        /// <value>
        /// The blog.
        /// </value>
        [ForeignKey("BlogId")]
        public virtual Blog Blog { get; set; }

        /// <summary>
        /// Gets or sets the blog category.
        /// </summary>
        /// <value>
        /// The blog category.
        /// </value>
        [ForeignKey("BlogCategoryId")]
        public virtual BlogCategory BlogCategory { get; set; }
    }

}
