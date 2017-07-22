namespace WebAPI.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPI.DataLayer.WebApiDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebAPI.DataLayer.WebApiDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //context.Blogs.AddOrUpdate(
            //  new Model.Blog
            //  {
            //      AuthorId = 1,
            //      BlogId = 1,
            //      BriefDescription = "BriefDescription",
            //      CreatedDate = DateTime.Now,
            //      Description = "Description...",
            //      ImageFile = "C:\\Images",
            //      IsActive = true,
            //      IsHottest = false,
            //      IsPopular = false,
            //      Name = "Example",
            //      NumView = 1000,
            //      Tags = "AAA"
            //  }
            //);

        }
    }
}
