using Sitecore.Mvc.Pipelines.Response.GetPageRendering;

namespace GC.Sitecore.ApplicationInsights.Processors
{
    public class InjectClientScriptsMvc : GetPageRenderingProcessor
    {
        public override void Process(GetPageRenderingArgs args)
        {
            args.Result = args.Result;
        }
    }
}