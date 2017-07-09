using Sitecore;
using Sitecore.Pipelines.RenderLayout;

namespace GC.Sitecore.ApplicationInsights.Processors
{
    public class InjectClientScripts : RenderLayoutProcessor
    {
        public override void Process(RenderLayoutArgs args)
        {
            var page = Context.Page;

            page?.Page.ClientScript.RegisterStartupScript(this.GetType(), "ApplicationInsightsKey", $"var myIKey = \"{Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration.Active.InstrumentationKey}\";", true);
            page?.Page.ClientScript.RegisterStartupScript(this.GetType(), "ApplicationInsightsScript", "<script type=\"text/javascript\" src=\"" + page?.Page.ResolveUrl("~/AIClientScript.js") + "\"></script>", false);

        }
    }
}