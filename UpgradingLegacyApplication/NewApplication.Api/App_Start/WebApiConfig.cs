using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace RefactoringApplication.Api
{
    public static class WebApiConfig
    {
        /// <summary>
        /// Register Web API configuration and services
        /// </summary>
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

        }
    }


}

