# CLAUDE.md — Nixtla SDK

## Overview

Auto-generated C# SDK for [Nixtla TimeGPT](https://nixtla.io/) — foundation model for time series forecasting, anomaly detection, cross-validation, and fine-tuning.
OpenAPI spec from `https://raw.githubusercontent.com/Nixtla/nixtla/main/timegpt-docs/openapi.json` (3.1.0).

## Build & Test

```bash
dotnet build Nixtla.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key via Bearer token:

```csharp
var client = new NixtlaClient(apiKey); // NIXTLA_API_KEY env var
```

## Key Files

- `src/libs/Nixtla/openapi.json` — OpenAPI 3.1.0 spec from Nixtla/nixtla repo
- `src/libs/Nixtla/generate.sh` — Downloads spec, adds top-level security, runs autosdk
- `src/libs/Nixtla/Generated/` — **Never edit** — auto-generated code
- `src/libs/Nixtla/Extensions/NixtlaClient.Tools.cs` — MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## API Endpoints

### V2 Endpoints (Primary)
```csharp
var client = new NixtlaClient(apiKey);

// Forecasting
client.V2ForecastAsync(request)                    // Multi-series forecast
client.V2HistoricForecastAsync(request)            // Historic (in-sample) forecast
client.V2CrossValidationAsync(request)             // Cross-validation

// Anomaly Detection
client.V2AnomalyDetectionAsync(request)            // Multi-series anomaly detection
client.V2OnlineAnomalyDetectionAsync(request)      // Online anomaly detection

// Fine-tuning
client.V2FinetuneAsync(request)                    // Fine-tune a model
client.V2FinetunedModelsV2FinetunedModelsGetAsync() // List fine-tuned models
client.V2FinetunedModelV2FinetunedModelsFinetunedModelIdGetAsync(id) // Get model
client.V2FinetunedModelsDeleteV2FinetunedModelsFinetunedModelIdDeleteAsync(id) // Delete model

// Validation
client.ValidateApiKeyValidateApiKeyGetAsync()      // Validate API key
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsForecastTool()` — Generate time series forecasts
- `AsAnomalyDetectionTool()` — Detect anomalies in time series data
- `AsListModelsTool()` — List fine-tuned models

## Spec Notes

- Base URL: `https://api.nixtla.io`
- Auth: HTTP Bearer (API key)
- Spec fix: `jq` adds top-level `security` array (spec only has per-operation)
- Suppressed CS8604 (nullable in generated excluded endpoint code)
