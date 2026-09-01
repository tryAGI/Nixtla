
#nullable enable

namespace Nixtla
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SeriesWithExogenous
    {
        /// <summary>
        /// Historic values of the exogenous features. Each feature must be a list of the same size as the target (y).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("X")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Nixtla.AnyOf<double?, string>>>? X { get; set; }

        /// <summary>
        /// Zero-based indices of the columns in X that are categorical features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categorical_exog")]
        public global::System.Collections.Generic.IList<int>? CategoricalExog { get; set; }

        /// <summary>
        /// Historic values of the target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Y { get; set; }

        /// <summary>
        /// Sizes of the individual series.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Sizes { get; set; }

        /// <summary>
        /// Starting timestamp of each individual series, as ISO 8601 strings (for example '2021-01-01' or '2021-01-01T09:30:00'). One entry per series, so it must have the same length as `sizes`. Together with `sizes` and `freq` this recovers the timestamps of every series.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_datetime")]
        public global::System.Collections.Generic.IList<string>? StartDatetime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesWithExogenous" /> class.
        /// </summary>
        /// <param name="y">
        /// Historic values of the target.
        /// </param>
        /// <param name="sizes">
        /// Sizes of the individual series.
        /// </param>
        /// <param name="x">
        /// Historic values of the exogenous features. Each feature must be a list of the same size as the target (y).
        /// </param>
        /// <param name="categoricalExog">
        /// Zero-based indices of the columns in X that are categorical features.
        /// </param>
        /// <param name="startDatetime">
        /// Starting timestamp of each individual series, as ISO 8601 strings (for example '2021-01-01' or '2021-01-01T09:30:00'). One entry per series, so it must have the same length as `sizes`. Together with `sizes` and `freq` this recovers the timestamps of every series.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SeriesWithExogenous(
            global::System.Collections.Generic.IList<double> y,
            global::System.Collections.Generic.IList<int> sizes,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Nixtla.AnyOf<double?, string>>>? x,
            global::System.Collections.Generic.IList<int>? categoricalExog,
            global::System.Collections.Generic.IList<string>? startDatetime)
        {
            this.X = x;
            this.CategoricalExog = categoricalExog;
            this.Y = y ?? throw new global::System.ArgumentNullException(nameof(y));
            this.Sizes = sizes ?? throw new global::System.ArgumentNullException(nameof(sizes));
            this.StartDatetime = startDatetime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesWithExogenous" /> class.
        /// </summary>
        public SeriesWithExogenous()
        {
        }

    }
}