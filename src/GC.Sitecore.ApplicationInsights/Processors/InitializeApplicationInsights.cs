using Sitecore.Pipelines;

namespace GC.Sitecore.ApplicationInsights.Processors
{
    public class InitializeApplicationInsights
    {
        public void Process(PipelineArgs args)
        {
            global::Sitecore.Diagnostics.Assert.ArgumentNotNull(args, "args");

            var key = global::Sitecore.Configuration.Settings.GetSetting("applicationInsightsInstrumentationKey");

            if (string.IsNullOrEmpty(key))
            {
                args.AbortPipeline();
                return;
            }

            Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration.Active.InstrumentationKey = key;
        }
    }
}