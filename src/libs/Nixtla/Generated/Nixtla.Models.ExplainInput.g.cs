
#nullable enable

namespace Nixtla
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExplainInput
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Nixtla.JsonConverters.ExplainInputMethodJsonConverter))]
        public global::Nixtla.ExplainInputMethod? Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExplainInput" /> class.
        /// </summary>
        /// <param name="series"></param>
        /// <param name="method">
        /// Model-agnostic causal analysis method used by the /v2/explain endpoint. Options are: 'granger' (default) and 'transfer_entropy'.<br/>
        /// Default Value: granger
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExplainInput(
            global::Nixtla.SeriesWithExogenous series,
            global::Nixtla.ExplainInputMethod? method)
        {
            this.Series = series ?? throw new global::System.ArgumentNullException(nameof(series));
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExplainInput" /> class.
        /// </summary>
        public ExplainInput()
        {
        }

    }
}