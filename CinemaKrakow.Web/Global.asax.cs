using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using System.Data.Entity;
using CinemaKrakow.Data.Services;

namespace CinemaKrakow.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<CinemaKrakowDbContext>(new DropCreateDatabaseIfModelChanges<CinemaKrakowDbContext>());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ContainerConfig.RegisterContainer(GlobalConfiguration.Configuration);
        }
    }
}
