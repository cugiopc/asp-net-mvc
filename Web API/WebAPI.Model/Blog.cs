// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Blog.cs" company="HAVA">
//   Copyright (c) HAVA, 2017
//   All rights are reserved. Reproduction or transmission in whole or in part, in
//   any form or by any means, electronic, mechanical or otherwise, is prohibited
//   without the prior written consent of the copyright owner.
// </copyright>
// <summary>
//   Defines the Blog type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace WebAPI.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Blog
    {
        /// <summary>
        /// Gets or sets the blog identifier.
        /// </summary>
        /// <value>
        /// The blog identifier.
        /// </value>
        public int BlogId { get; set; }

        /// <summary>
        /// Gets or sets the image file.
        /// </summary>
        /// <value>
        /// The image file.
        /// </value>
        [MaxLength(150)]
        public string ImageFile { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [MaxLength(150)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the brief description.
        /// </summary>
        /// <value>
        /// The brief description.
        /// </value>
        [MaxLength(300)]
        public string BriefDescription { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [Column(TypeName = "ntext")]
        [MaxLength]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is hottest.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is hottest; otherwise, <c>false</c>.
        /// </value>
        public bool IsHottest { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is popular.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is popular; otherwise, <c>false</c>.
        /// </value>
        public bool IsPopular { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>
        /// The tags.
        /// </value>
        [MaxLength(300)]
        public string Tags { get; set; }

        /// <summary>
        /// Gets or sets the author identifier.
        /// </summary>
        /// <value>
        /// The author identifier.
        /// </value>
        public int AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the number view.
        /// </summary>
        /// <value>
        /// The number view.
        /// </value>
        public long NumView { get; set; }

        /// <summary>
        /// Gets or sets the test field.
        /// </summary>
        /// <value>
        /// The test field.
        /// </value>
        public string TestField { get; set; }

    }

}
