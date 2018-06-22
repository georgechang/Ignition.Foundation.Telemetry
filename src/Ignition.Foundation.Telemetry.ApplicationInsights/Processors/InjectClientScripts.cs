using Sitecore.Pipelines.RenderLayout;

namespace Ignition.Foundation.Telemetry.ApplicationInsights.Processors
{
    public class InjectClientScripts : RenderLayoutProcessor
    {
        public override void Process(RenderLayoutArgs args)
        {
            var page = Sitecore.Context.Page;

            page?.Page.ClientScript.RegisterStartupScript(this.GetType(), "ApplicationInsightsKey", Scripts.KeyScript, false);
            page?.Page.ClientScript.RegisterStartupScript(this.GetType(), "ApplicationInsightsScript", Scripts.ClientScript , false);

        }
    }
}