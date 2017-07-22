// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlogTag.cs" company="HAVA">
//   Copyright (c) HAVA, 2017
//   All rights are reserved. Reproduction or transmission in whole or in part, in
//   any form or by any means, electronic, mechanical or otherwise, is prohibited
//   without the prior written consent of the copyright owner.
// </copyright>
// <summary>
//   Defines the BlogTag type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace WebAPI.Model
{
    using System.ComponentModel.DataAnnotations;

    public class BlogTag
    {
        /// <summary>
        /// Gets or sets the blog tag identifier.
        /// </summary>
        /// <value>
        /// The blog tag identifier.
        /// </value>
        public int BlogTagId { get; set; }

        /// <summary>
        /// Gets or sets the name of the tag.
        /// </summary>
        /// <value>
        /// The name of the tag.
        /// </value>
        [MaxLength(150)]
        public string TagName { get; set; }
    }
}
