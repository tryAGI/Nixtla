
#nullable enable

namespace Nixtla
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExplainOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Weights { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature_names")]
        public global::System.Collections.Generic.IList<string>? FeatureNames { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExplainOutput" /> class.
        /// </summary>
        /// <param name="weights"></param>
        /// <param name="method"></param>
        /// <param name="featureNames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExplainOutput(
            global::System.Collections.Generic.IList<double> weights,
            string method,
            global::System.Collections.Generic.IList<string>? featureNames)
        {
            this.Weights = weights ?? throw new global::System.ArgumentNullException(nameof(weights));
            this.FeatureNames = featureNames;
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExplainOutput" /> class.
        /// </summary>
        public ExplainOutput()
        {
        }

    }
}