using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;
using FilmSessionData.Infrastructures;
using FilmSessionData;
using FilmSessionData.Repositories;
using FilmSessionService;
using System.Web.Mvc;
using System.Web.Http;
using FilmSessionWeb.Controllers;
using System.Diagnostics;

[assembly: OwinStartup(typeof(FilmSessionWeb.App_Start.Startup))]

namespace FilmSessionWeb.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            ConfigAutofac(app);
            Debug.WriteLine("Enter Startup!!!");
        }
        private void ConfigAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            //register for web controller and web api
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterType<TestCodeFirstEntityDbContext>().AsSelf().InstancePerRequest();

            //repository
            builder.RegisterAssemblyTypes(typeof(FilmRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            //service 
            builder.RegisterAssemblyTypes(typeof(FilmService).Assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //set web api and controller
        }
    }
}
