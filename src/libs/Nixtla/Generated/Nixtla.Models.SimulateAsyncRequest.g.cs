
#nullable enable

namespace Nixtla
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulateAsyncRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Nixtla.SeriesWithFutureExogenous Series { get; set; }

        /// <summary>
        /// The frequency of the data represented as a string. 'D' for daily, 'M' for monthly, 'H' for hourly, and 'W' for weekly frequencies are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freq")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Freq { get; set; }

        /// <summary>
        /// The forecasting horizon. This represents the number of time steps into the future that the forecast should predict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int H { get; set; }

        /// <summary>
        /// Model to use as a string. Common options are (but not restricted to) `timegpt-1` and `timegpt-1-long-horizon`. Full options vary by different users. Contact support@nixtla.io for more information. We recommend using `timegpt-1-long-horizon` for forecasting if you want to predict more than one seasonal period given the frequency of your data.<br/>
        /// Default Value: timegpt-1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// ID of previously finetuned model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetuned_model_id")]
        public string? FinetunedModelId { get; set; }

        /// <summary>
        /// A boolean flag that indicates whether the API should preprocess (clean) the exogenous signal before applying the large time model. If True, the exogenous signal is cleaned; if False, the exogenous variables are applied after the large time model.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clean_ex_first")]
        public bool? CleanExFirst { get; set; }

        /// <summary>
        /// When True, sample paths are coupled across series via a shared-template Schaake shuffle (path k reflects the same historical period for every series) — this applies to ALL models. Falls back to independent per-series paths when no NaN-free shared history window exists (see `coupled` in the response). Also enables the multivariate marginal forecast for models that support it (timegpt-2.1).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multivariate")]
        public bool? Multivariate { get; set; }

        /// <summary>
        /// Number of sample paths to generate per series.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_paths")]
        public int? NPaths { get; set; }

        /// <summary>
        /// Marginal quantile grid in (0, 1), strictly increasing, length in [2, 200]. Defaults to the model's native grid (native-quantile losses) or a dense grid (point-loss/conformal).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantiles")]
        public global::System.Collections.Generic.IList<double>? Quantiles { get; set; }

        /// <summary>
        /// Random seed for reproducibility. When omitted, a fresh random seed is drawn, so repeated unseeded requests return different paths.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_options")]
        public global::Nixtla.AsyncJobOptions? JobOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulateAsyncRequest" /> class.
        /// </summary>
        /// <param name="series"></param>
        /// <param name="freq">
        /// The frequency of the data represented as a string. 'D' for daily, 'M' for monthly, 'H' for hourly, and 'W' for weekly frequencies are available.
        /// </param>
        /// <param name="h">
        /// The forecasting horizon. This represents the number of time steps into the future that the forecast should predict.
        /// </param>
        /// <param name="model">
        /// Model to use as a string. Common options are (but not restricted to) `timegpt-1` and `timegpt-1-long-horizon`. Full options vary by different users. Contact support@nixtla.io for more information. We recommend using `timegpt-1-long-horizon` for forecasting if you want to predict more than one seasonal period given the frequency of your data.<br/>
        /// Default Value: timegpt-1
        /// </param>
        /// <param name="finetunedModelId">
        /// ID of previously finetuned model
        /// </param>
        /// <param name="cleanExFirst">
        /// A boolean flag that indicates whether the API should preprocess (clean) the exogenous signal before applying the large time model. If True, the exogenous signal is cleaned; if False, the exogenous variables are applied after the large time model.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="multivariate">
        /// When True, sample paths are coupled across series via a shared-template Schaake shuffle (path k reflects the same historical period for every series) — this applies to ALL models. Falls back to independent per-series paths when no NaN-free shared history window exists (see `coupled` in the response). Also enables the multivariate marginal forecast for models that support it (timegpt-2.1).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="nPaths">
        /// Number of sample paths to generate per series.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="quantiles">
        /// Marginal quantile grid in (0, 1), strictly increasing, length in [2, 200]. Defaults to the model's native grid (native-quantile losses) or a dense grid (point-loss/conformal).
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility. When omitted, a fresh random seed is drawn, so repeated unseeded requests return different paths.
        /// </param>
        /// <param name="jobOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulateAsyncRequest(
            global::Nixtla.SeriesWithFutureExogenous series,
            string freq,
            int h,
            string? model,
            string? finetunedModelId,
            bool? cleanExFirst,
            bool? multivariate,
            int? nPaths,
            global::System.Collections.Generic.IList<double>? quantiles,
            int? seed,
            global::Nixtla.AsyncJobOptions? jobOptions)
        {
            this.Series = series ?? throw new global::System.ArgumentNullException(nameof(series));
            this.Freq = freq ?? throw new global::System.ArgumentNullException(nameof(freq));
            this.H = h;
            this.Model = model;
            this.FinetunedModelId = finetunedModelId;
            this.CleanExFirst = cleanExFirst;
            this.Multivariate = multivariate;
            this.NPaths = nPaths;
            this.Quantiles = quantiles;
            this.Seed = seed;
            this.JobOptions = jobOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulateAsyncRequest" /> class.
        /// </summary>
        public SimulateAsyncRequest()
        {
        }

    }
}