
#nullable enable

namespace Nixtla
{
    /// <summary>
    /// The 202 every async submit returns. Shared by all tasks — they differ in request, not reply.
    /// </summary>
    public sealed partial class AsyncJobSubmitResponse
    {
        /// <summary>
        /// Identifier for the accepted job. Prefixed per task (e.g. `fc-` for forecast).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncJobSubmitResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Identifier for the accepted job. Prefixed per task (e.g. `fc-` for forecast).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncJobSubmitResponse(
            string jobId)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncJobSubmitResponse" /> class.
        /// </summary>
        public AsyncJobSubmitResponse()
        {
        }

    }
}