
#nullable enable

namespace Nixtla
{
    /// <summary>
    /// Method used to compute feature contributions. Options are: 'shapley' (default), 'intervention', 'granger', 'transfer_entropy'. The methods differ in semantics: 'shapley' returns per-timestep contributions that sum to the forecast (last row = per-timestep base prediction); 'intervention' returns each feature's counterfactual effect (forecast minus forecast with that feature held at its baseline) and does NOT sum to the forecast; 'granger'/'transfer_entropy' allocate each series' forecast deviation from its mean proportionally to model-agnostic historical importance weights — the rows sum to the forecast by construction, but they are a proportional allocation describing relationships in the data, not a per-feature attribution of this specific forecast. Use the /v2/explain endpoint for standalone historical importance weights.<br/>
    /// Default Value: shapley
    /// </summary>
    public enum ForecastAsyncRequestFeatureContributionsType
    {
        /// <summary>
        /// 'shapley' (default), 'intervention', 'granger', 'transfer_entropy'. The methods differ in semantics: 'shapley' returns per-timestep contributions that sum to the forecast (last row = per-timestep base prediction); 'intervention' returns each feature's counterfactual effect (forecast minus forecast with that feature held at its baseline) and does NOT sum to the forecast; 'granger'/'transfer_entropy' allocate each series' forecast deviation from its mean proportionally to model-agnostic historical importance weights — the rows sum to the forecast by construction, but they are a proportional allocation describing relationships in the data, not a per-feature attribution of this specific forecast. Use the /v2/explain endpoint for standalone historical importance weights.
        /// </summary>
        Granger,
        /// <summary>
        /// 'shapley' (default), 'intervention', 'granger', 'transfer_entropy'. The methods differ in semantics: 'shapley' returns per-timestep contributions that sum to the forecast (last row = per-timestep base prediction); 'intervention' returns each feature's counterfactual effect (forecast minus forecast with that feature held at its baseline) and does NOT sum to the forecast; 'granger'/'transfer_entropy' allocate each series' forecast deviation from its mean proportionally to model-agnostic historical importance weights — the rows sum to the forecast by construction, but they are a proportional allocation describing relationships in the data, not a per-feature attribution of this specific forecast. Use the /v2/explain endpoint for standalone historical importance weights.
        /// </summary>
        Intervention,
        /// <summary>
        /// 'shapley' (default), 'intervention', 'granger', 'transfer_entropy'. The methods differ in semantics: 'shapley' returns per-timestep contributions that sum to the forecast (last row = per-timestep base prediction); 'intervention' returns each feature's counterfactual effect (forecast minus forecast with that feature held at its baseline) and does NOT sum to the forecast; 'granger'/'transfer_entropy' allocate each series' forecast deviation from its mean proportionally to model-agnostic historical importance weights — the rows sum to the forecast by construction, but they are a proportional allocation describing relationships in the data, not a per-feature attribution of this specific forecast. Use the /v2/explain endpoint for standalone historical importance weights.
        /// </summary>
        Shapley,
        /// <summary>
        /// 'shapley' (default), 'intervention', 'granger', 'transfer_entropy'. The methods differ in semantics: 'shapley' returns per-timestep contributions that sum to the forecast (last row = per-timestep base prediction); 'intervention' returns each feature's counterfactual effect (forecast minus forecast with that feature held at its baseline) and does NOT sum to the forecast; 'granger'/'transfer_entropy' allocate each series' forecast deviation from its mean proportionally to model-agnostic historical importance weights — the rows sum to the forecast by construction, but they are a proportional allocation describing relationships in the data, not a per-feature attribution of this specific forecast. Use the /v2/explain endpoint for standalone historical importance weights.
        /// </summary>
        TransferEntropy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ForecastAsyncRequestFeatureContributionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ForecastAsyncRequestFeatureContributionsType value)
        {
            return value switch
            {
                ForecastAsyncRequestFeatureContributionsType.Granger => "granger",
                ForecastAsyncRequestFeatureContributionsType.Intervention => "intervention",
                ForecastAsyncRequestFeatureContributionsType.Shapley => "shapley",
                ForecastAsyncRequestFeatureContributionsType.TransferEntropy => "transfer_entropy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ForecastAsyncRequestFeatureContributionsType? ToEnum(string value)
        {
            return value switch
            {
                "granger" => ForecastAsyncRequestFeatureContributionsType.Granger,
                "intervention" => ForecastAsyncRequestFeatureContributionsType.Intervention,
                "shapley" => ForecastAsyncRequestFeatureContributionsType.Shapley,
                "transfer_entropy" => ForecastAsyncRequestFeatureContributionsType.TransferEntropy,
                _ => null,
            };
        }
    }
}