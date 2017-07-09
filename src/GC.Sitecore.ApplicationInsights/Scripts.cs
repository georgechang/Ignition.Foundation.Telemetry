using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore;
using Sitecore.Layouts;

namespace GC.Sitecore.ApplicationInsights
{
    public static class Scripts
    {
        public static string KeyScript = $@"<script type=""text/javascript"">var myIKey = ""{Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration.Active.InstrumentationKey}"";</script>";
        public static string ClientScript => @"<script type=""text/javascript"" src=""" + VirtualPathUtility.ToAbsolute("~/AIClientScript.js") + "\"></script>";
    }
}