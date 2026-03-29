# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Nixtla SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models time series forecasting, anomaly detection, and model management capabilities.

## Installation

```bash
dotnet add package tryAGI.Nixtla
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsForecastTool()` | `Nixtla_Forecast` | Generate time series forecasts |
| `AsAnomalyDetectionTool()` | `Nixtla_AnomalyDetection` | Detect anomalies in time series data |
| `AsListModelsTool()` | `Nixtla_ListModels` | List available fine-tuned models |

## Usage

```csharp
using Microsoft.Extensions.AI;
using Nixtla;

var client = new NixtlaClient(
    apiKey: Environment.GetEnvironmentVariable("NIXTLA_API_KEY")!);

var options = new ChatOptions
{
    Tools = [client.AsForecastTool()],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Generate a 7-day forecast for my sales data"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
