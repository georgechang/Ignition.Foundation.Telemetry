using System.Web;

namespace Ignition.Foundation.Telemetry.ApplicationInsights
{
    public static class Scripts
    {
        public static string KeyScript = $@"<script type=""text/javascript"">var myIKey = ""{Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration.Active.InstrumentationKey}"";</script>";
        public static string ClientScript => @"<script type=""text/javascript"" src=""" + VirtualPathUtility.ToAbsolute("~/AIClientScript.js") + "\"></script>";
    }
}