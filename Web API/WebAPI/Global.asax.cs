using System.Data.Entity;
using System.Web.Http;
using WebAPI.DataLayer;

namespace WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Applications the start.
        /// </summary>
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var db = new WebApiDbInitalize();
            Database.SetInitializer(db);
        }
    }
}
