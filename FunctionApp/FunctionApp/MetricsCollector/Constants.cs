namespace FunctionApp.MetricsCollector
{
    public static class Constants
    {
        public static readonly string VersionNumber = "0.1.2.0";  // TODO: grab this from somewhere else
        public static readonly string MetricOrigin = "iot.azm.ms";
        public static readonly string MetricNamespace = "metricsmodule";
        public static readonly string MetricComputer = "";  // TODO: maybe put a short value here? Customers pay for the storage though...
        public static readonly string MetricUploadIPName = "IotInsights";  // We don't think log analytics uses this string. If anything maybe for billing?
        public static readonly string MetricUploadDataType = "INSIGHTS_METRICS_BLOB";
        public static readonly string IoTUploadMessageIdentifier = "Microsoft.Azure.Devices.Azure.Monitor";
        public static readonly int UploadMaxRetries = 3;
        public const string DefaultLogAnalyticsWorkspaceDomain = "opinsights.azure.com";
        public const string ProductInfo = "Microsoft.Azure.Devices.Azure.Monitor";
    }
}