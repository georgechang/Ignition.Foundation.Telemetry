using Sitecore.Pipelines;

namespace Ignition.Foundation.Telemetry.ApplicationInsights.Processors
{
    public class InitializeApplicationInsights
    {
        public void Process(PipelineArgs args)
        {
            Sitecore.Diagnostics.Assert.ArgumentNotNull(args, "args");

            var key = Sitecore.Configuration.Settings.GetSetting("applicationInsightsInstrumentationKey");

            if (string.IsNullOrEmpty(key))
            {
                args.AbortPipeline();
                return;
            }

            Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration.Active.InstrumentationKey = key;
        }
    }
}