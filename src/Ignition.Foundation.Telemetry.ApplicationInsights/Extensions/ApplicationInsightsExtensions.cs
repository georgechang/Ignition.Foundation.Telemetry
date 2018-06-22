using System.Web;
using Sitecore.Mvc.Helpers;

namespace Ignition.Foundation.Telemetry.ApplicationInsights.Extensions
{
    public static class ApplicationInsightsExtensions
    {
        public static IHtmlString ApplicationInsights(this SitecoreHelper helper)
        {
            return new HtmlString(Scripts.KeyScript + Scripts.ClientScript);
        }
    }
}