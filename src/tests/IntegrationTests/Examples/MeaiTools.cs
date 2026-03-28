/* order: 20, title: MEAI Tools, slug: meai-tools */

namespace Nixtla.IntegrationTests.Examples;

[TestClass]
public class MeaiTools
{
    //// Nixtla provides `AIFunction` tools that can be used with any `IChatClient`
    //// for function/tool calling scenarios.

    [TestMethod]
    public void CreateTools()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("NIXTLA_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("NIXTLA_API_KEY environment variable is not found.");

        using var client = new NixtlaClient(apiKey);

        //// Create tools for forecasting, anomaly detection, and model listing.
        var forecastTool = client.AsForecastTool();
        var anomalyDetectionTool = client.AsAnomalyDetectionTool();
        var listModelsTool = client.AsListModelsTool();

        Assert.AreEqual("Nixtla_Forecast", forecastTool.Name);
        Assert.AreEqual("Nixtla_AnomalyDetection", anomalyDetectionTool.Name);
        Assert.AreEqual("Nixtla_ListModels", listModelsTool.Name);

        //// These tools can be passed to any IChatClient that supports function calling.
        var tools = new[] { forecastTool, anomalyDetectionTool, listModelsTool };
        Assert.AreEqual(3, tools.Length);
    }
}
