using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace Laboratorio203
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Configuraci�n de Friendly URLs
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);
        }
    }
}