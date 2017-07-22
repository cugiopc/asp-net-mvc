using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Model;

namespace WebAPI.DataLayer
{
    public class BlogRepository
    {
        private WebApiDataContext dbContext = new WebApiDataContext();

        public IEnumerable<Blog> GetAll()
        {
            return this.dbContext.Blogs;
        }
    }
}
