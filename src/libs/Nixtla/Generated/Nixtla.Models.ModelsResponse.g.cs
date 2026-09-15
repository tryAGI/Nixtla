
#nullable enable

namespace Nixtla
{
    /// <summary>
    /// The body of `GET /v2/models`, which the gateway and compute apps both serve.<br/>
    /// Which models appear is each endpoint's own business — the gateway scopes the list to the<br/>
    /// caller's entitlements, a compute container lists everything it serves — but the shape is<br/>
    /// declared once here so a client written against one deployment works against the other.
    /// </summary>
    public sealed partial class ModelsResponse
    {
        /// <summary>
        /// Available models, sorted by name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Nixtla.ModelInfo> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsResponse" /> class.
        /// </summary>
        /// <param name="models">
        /// Available models, sorted by name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsResponse(
            global::System.Collections.Generic.IList<global::Nixtla.ModelInfo> models)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsResponse" /> class.
        /// </summary>
        public ModelsResponse()
        {
        }

    }
}