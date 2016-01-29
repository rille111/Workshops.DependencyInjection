using System.Web.Http;
using NewApplication.Api.Domain.Services;
using NewApplication.Api.Infrastructure;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

namespace NewApplication.Api
{
    public static class SimpleInjectorConfig
    {
        /// <summary>
        /// Bootstrapping for Simple Injector ..
        /// </summary>
        public static void ConfigureContainer()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            PerformRegistrations(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);

        }

        /// <summary>
        /// Application-specific registrations for Simple Injector
        /// </summary>
        private static void PerformRegistrations(Container container)
        {
            container.Register<ICustomLogger, ConsoleLogger>(Lifestyle.Scoped);
            container.Register<ICompanyLoader>(() =>
            {
                if (CurrentConfiguration.LoadFromJson)
                {
                    return new JsonCompanyLoader(container.GetInstance<ICustomLogger>());
                }
                else
                {
                    return new HardCodedCompanyLoader(container.GetInstance<ICustomLogger>());
                }
            });
            container.RegisterDecorator(typeof (ICompanyLoader), typeof (CompanyLoaderLoggingDecorator));
        }
    }
}