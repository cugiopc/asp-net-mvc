using StarMovie.Models.Entity;
using System.Data.Entity;

namespace StarMovie.Models
{
    public class StarMovieDbContext : DbContext
    {
        /// <summary>
        /// Gets or sets the movies.
        /// </summary>
        /// <value>
        /// The movies.
        /// </value>
        public DbSet<Movie> Movies { get; set; }

    }
}