/* order: 10, title: Forecasting, slug: forecasting */

namespace Nixtla.IntegrationTests.Examples;

[TestClass]
public class Forecasting
{
    //// Nixtla TimeGPT provides time series forecasting, anomaly detection,
    //// and cross-validation through a simple API.

    [TestMethod]
    public void CreateClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("NIXTLA_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("NIXTLA_API_KEY environment variable is not found.");

        using var client = new NixtlaClient(apiKey);

        //// The client provides direct access to forecasting, anomaly detection,
        //// cross-validation, and fine-tuning endpoints.
        Assert.IsNotNull(client);
    }
}
