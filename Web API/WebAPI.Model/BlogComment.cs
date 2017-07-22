// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlogComment.cs" company="HAVA">
//   Copyright (c) HAVA, 2017
//   All rights are reserved. Reproduction or transmission in whole or in part, in
//   any form or by any means, electronic, mechanical or otherwise, is prohibited
//   without the prior written consent of the copyright owner.
// </copyright>
// <summary>
//   Defines the BlogComment type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace WebAPI.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class BlogComment
    {
        /// <summary>
        /// Gets or sets the blog comment identifier.
        /// </summary>
        /// <value>
        /// The blog comment identifier.
        /// </value>
        public int BlogCommentId { get; set; }

        /// <summary>
        /// Gets or sets the content detail.
        /// </summary>
        /// <value>
        /// The content detail.
        /// </value>
        [MaxLength(600)]
        public string ContentDetail { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the blog identifier.
        /// </summary>
        /// <value>
        /// The blog identifier.
        /// </value>
        public int BlogId { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or sets the parent blog comment identifier.
        /// </summary>
        /// <value>
        /// The parent blog comment identifier.
        /// </value>
        public int? ParentBlogCommentId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BlogComment"/> is gender.
        /// </summary>
        /// <value>
        ///   <c>true</c> if gender; otherwise, <c>false</c>.
        /// </value>
        public int Gender { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        [MaxLength(50)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [MaxLength(50)]
        public string Email { get; set; }

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