using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.DataLayer;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    public class BlogController : ApiController
    {
        private BlogRepository blogRepository = new BlogRepository();

        // GET: api/Blog
        public IEnumerable<Blog> Get()
        {
            return this.blogRepository.GetAll();
        }

        // GET: api/Blog/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Blog
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Blog/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Blog/5
        public void Delete(int id)
        {
        }
    }
}
