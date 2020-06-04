using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using CinemaKrakow.Data.Services;
using System.Web.Http;
using System.Web.Mvc;

namespace CinemaKrakow.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<SqlModeratorData>()
                .As<IModeratorData>()
                .InstancePerRequest();
            builder.RegisterType<SqlMovieData>()
                   .As<IMovieData>()
                   .InstancePerRequest();
            builder.RegisterType<CinemaKrakowDbContext>().InstancePerRequest();
             
            
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}