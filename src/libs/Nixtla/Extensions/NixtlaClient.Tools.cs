#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Nixtla;

public static class NixtlaClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that generates time series forecasts using TimeGPT.
    /// </summary>
    public static AIFunction AsForecastTool(this NixtlaClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Comma-separated numeric values representing the time series observations in chronological order")] string values,
                   [Description("Number of future time steps to forecast")] int horizon,
                   [Description("Frequency of the data: 'D' for daily, 'H' for hourly, 'M' for monthly, 'W' for weekly")] string frequency,
                   CancellationToken cancellationToken) =>
            {
                var y = values.Split(',')
                    .Select(v => double.Parse(v.Trim(), System.Globalization.CultureInfo.InvariantCulture))
                    .ToList();

                var series = new SeriesWithFutureExogenous
                {
                    Y = y,
                    Sizes = [y.Count],
                };

                var request = new ForecastInput
                {
                    Series = series,
                    Freq = frequency,
                    H = horizon,
                };

                var response = await client.V2ForecastAsync(
                    request: request,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Mean,
                    response.Intervals,
                    response.InputTokens,
                    response.OutputTokens,
                };
            },
            name: "Nixtla_Forecast",
            description: "Generate time series forecasts using Nixtla TimeGPT. Provide historical time series data as comma-separated values and get future predictions.");
    }

    /// <summary>
    /// Creates an AIFunction tool that detects anomalies in time series data using TimeGPT.
    /// </summary>
    public static AIFunction AsAnomalyDetectionTool(this NixtlaClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Comma-separated numeric values representing the time series observations in chronological order")] string values,
                   [Description("Frequency of the data: 'D' for daily, 'H' for hourly, 'M' for monthly, 'W' for weekly")] string frequency,
                   CancellationToken cancellationToken) =>
            {
                var y = values.Split(',')
                    .Select(v => double.Parse(v.Trim(), System.Globalization.CultureInfo.InvariantCulture))
                    .ToList();

                var series = new SeriesWithExogenous
                {
                    Y = y,
                    Sizes = [y.Count],
                };

                var request = new AnomalyDetectionInput
                {
                    Series = series,
                    Freq = frequency,
                };

                var response = await client.V2AnomalyDetectionAsync(
                    request: request,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Mean,
                    response.Anomaly,
                    response.Intervals,
                    response.InputTokens,
                    response.OutputTokens,
                };
            },
            name: "Nixtla_AnomalyDetection",
            description: "Detect anomalies in time series data using Nixtla TimeGPT. Identifies unusual patterns and outliers in historical data.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists fine-tuned models.
    /// </summary>
    public static AIFunction AsListModelsTool(this NixtlaClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.V2FinetunedModelsV2FinetunedModelsGetAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Nixtla_ListModels",
            description: "List all fine-tuned TimeGPT models available for forecasting. Returns model IDs and metadata.");
    }
}
