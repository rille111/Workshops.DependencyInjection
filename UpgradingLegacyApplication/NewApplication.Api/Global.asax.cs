using System.Linq;
using System.Web.Http;

namespace RefactoringApplication.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            SimpleInjectorConfig.ConfigureContainer();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RemoveXmlFormatter(GlobalConfiguration.Configuration);
        }

        private void RemoveXmlFormatter(HttpConfiguration config)
        {
            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }

    }
}
