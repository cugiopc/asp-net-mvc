using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.DataLayer
{
    public class WebApiDbInitalize : DropCreateDatabaseIfModelChanges<WebApiDataContext>
    {
        protected override void Seed(WebAPI.DataLayer.WebApiDataContext context)
        {
            context.Blogs.Add(
              new Model.Blog
              {
                  AuthorId = 1,
                  BlogId = 1,
                  BriefDescription = "BriefDescription",
                  CreatedDate = DateTime.Now,
                  Description = "Description...",
                  ImageFile = "C:\\Images",
                  IsActive = true,
                  IsHottest = false,
                  IsPopular = false,
                  Name = "Example",
                  NumView = 1000,
                  Tags = "AAA"
              }
            );

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
