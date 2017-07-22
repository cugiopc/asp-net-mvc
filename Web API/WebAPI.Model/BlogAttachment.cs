// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlogAttachment.cs" company="HAVA">
//   Copyright (c) HAVA, 2017
//   All rights are reserved. Reproduction or transmission in whole or in part, in
//   any form or by any means, electronic, mechanical or otherwise, is prohibited
//   without the prior written consent of the copyright owner.
// </copyright>
// <summary>
//   Defines the BlogAttachment type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace WebAPI.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class BlogAttachment
    {
        /// <summary>
        /// Gets or sets the blog attachment identifier.
        /// </summary>
        /// <value>
        /// The blog attachment identifier.
        /// </value>
        public int BlogAttachmentId { get; set; }

        /// <summary>
        /// Gets or sets the blog identifier.
        /// </summary>
        /// <value>
        /// The blog identifier.
        /// </value>
        public int BlogId { get; set; }

        /// <summary>
        /// Gets or sets the attached file.
        /// </summary>
        /// <value>
        /// The attached file.
        /// </value>
        [MaxLength(150)]
        public string AttachedFile { get; set; }

        /// <summary>
        /// Gets or sets the blog.
        /// </summary>
        /// <value>
        /// The blog.
        /// </value>
        [ForeignKey("BlogId")]
        public virtual Blog Blog { get; set; }
    }
}