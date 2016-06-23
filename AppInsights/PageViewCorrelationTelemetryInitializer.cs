using System;
using System.Web;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace TodoMvc.AppInsights
{
    public class PageViewCorrelationTelemetryInitializer : ITelemetryInitializer
    {
        public void Initialize(ITelemetry telemetry)
        {
            RequestTelemetry request = telemetry as RequestTelemetry;
            if (HttpContext.Current == null || request == null) return;

            string ajaxOpId = HttpContext.Current.Request.Unvalidated.Headers["ai-pv-opid"];
            if (!String.IsNullOrWhiteSpace(ajaxOpId))
            {
                request.Context.Operation.Id = ajaxOpId;
            }
        }
    }
}