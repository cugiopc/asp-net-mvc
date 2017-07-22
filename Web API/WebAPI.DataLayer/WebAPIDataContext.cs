using System.Data.Entity;
using WebAPI.Model;

namespace WebAPI.DataLayer
{
    public class WebApiDataContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebApiDataContext"/> class.
        /// </summary>
        public WebApiDataContext() : base("name=WebApiDbContextSQL")
        {
        }

        /// <summary>
        /// Gets or sets the blog tags.
        /// </summary>
        /// <value>
        /// The blog tags.
        /// </value>
        public virtual DbSet<BlogTag> BlogTags { get; set; }

        /// <summary>
        /// Gets or sets the blog categories.
        /// </summary>
        /// <value>
        /// The blog categories.
        /// </value>
        public virtual DbSet<BlogCategory> BlogCategories { get; set; }

        /// <summary>
        /// Gets or sets the blogs.
        /// </summary>
        /// <value>
        /// The blogs.
        /// </value>
        public virtual DbSet<Blog> Blogs { get; set; }

        /// <summary>
        /// Gets or sets the blog category relationships.
        /// </summary>
        /// <value>
        /// The blog category relationships.
        /// </value>
        public virtual DbSet<BlogCategoryRelationship> BlogCategoryRelationships { get; set; }

        /// <summary>
        /// Gets or sets the blog comments.
        /// </summary>
        /// <value>
        /// The blog comments.
        /// </value>
        public virtual DbSet<BlogComment> BlogComments { get; set; }

        /// <summary>
        /// Gets or sets the blog attachments.
        /// </summary>
        /// <value>
        /// The blog attachments.
        /// </value>
        public virtual DbSet<BlogAttachment> BlogAttachments { get; set; }
    }
}
