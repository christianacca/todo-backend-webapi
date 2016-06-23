using System;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace TodoMvc.AppInsights
{
    public class DebugginTelemetryInitializer : ITelemetryInitializer
    {
        public void Initialize(ITelemetry telemetry)
        {
            RequestTelemetry request = telemetry as RequestTelemetry;
            DependencyTelemetry dependency = telemetry as DependencyTelemetry;
            if (request != null)
            {
                Console.Out.WriteLine("request.Id = {0}", request.Id);
                Console.Out.WriteLine("request.Context.Operation.Id = {0}", request.Context.Operation.Id);
            }
            Console.Out.WriteLine("dependency = {0}", dependency);
        }
    }
}