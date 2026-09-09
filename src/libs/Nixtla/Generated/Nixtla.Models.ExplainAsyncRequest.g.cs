
#nullable enable

namespace Nixtla
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExplainAsyncRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Nixtla.SeriesWithExogenous Series { get; set; }

        /// <summary>
        /// Model-agnostic causal analysis method used by the /v2/explain endpoint. Options are: 'granger' (default) and 'transfer_entropy'.<br/>
        /// Default Value: granger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Nixtla.JsonConverters.ExplainAsyncRequestMethodJsonConverter))]
        public global::Nixtla.ExplainAsyncRequestMethod? Method { get; set; }

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
        /// Initializes a new instance of the <see cref="ExplainAsyncRequest" /> class.
        /// </summary>
        /// <param name="series"></param>
        /// <param name="method">
        /// Model-agnostic causal analysis method used by the /v2/explain endpoint. Options are: 'granger' (default) and 'transfer_entropy'.<br/>
        /// Default Value: granger
        /// </param>
        /// <param name="jobOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExplainAsyncRequest(
            global::Nixtla.SeriesWithExogenous series,
            global::Nixtla.ExplainAsyncRequestMethod? method,
            global::Nixtla.AsyncJobOptions? jobOptions)
        {
            this.Series = series ?? throw new global::System.ArgumentNullException(nameof(series));
            this.Method = method;
            this.JobOptions = jobOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExplainAsyncRequest" /> class.
        /// </summary>
        public ExplainAsyncRequest()
        {
        }

    }
}