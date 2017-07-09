using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Mvc.Helpers;

namespace GC.Sitecore.ApplicationInsights.Extensions
{
    public static class ApplicationInsightsExtensions
    {
        public static IHtmlString ApplicationInsights(this SitecoreHelper helper)
        {
            return new HtmlString(Scripts.KeyScript + Scripts.ClientScript);
        }
    }
}