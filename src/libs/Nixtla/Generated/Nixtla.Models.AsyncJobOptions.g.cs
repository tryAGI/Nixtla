
#nullable enable

namespace Nixtla
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AsyncJobOptions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncJobOptions" /> class.
        /// </summary>
        /// <param name="timeoutSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncJobOptions(
            int? timeoutSeconds)
        {
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncJobOptions" /> class.
        /// </summary>
        public AsyncJobOptions()
        {
        }

    }
}