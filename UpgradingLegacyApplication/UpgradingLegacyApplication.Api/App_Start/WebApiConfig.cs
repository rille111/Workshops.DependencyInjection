using System.Web.Http;

namespace UpgradingLegacyApplication.Api
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

