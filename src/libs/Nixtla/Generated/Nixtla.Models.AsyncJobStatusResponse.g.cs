
#nullable enable

namespace Nixtla
{
    /// <summary>
    /// A job's current state, polled from the per-task status endpoint.<br/>
    /// `result` is populated only once `status` is `succeeded`, and stays null for a binary task whose<br/>
    /// output is a zip — that arrives from the task's dedicated result endpoint instead.
    /// </summary>
    public sealed partial class AsyncJobStatusResponse
    {
        /// <summary>
        /// The job this status describes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Lifecycle state; terminal states are succeeded, failed, cancelled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Nixtla.JsonConverters.AsyncJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Nixtla.AsyncJobStatus Status { get; set; }

        /// <summary>
        /// The task's output once succeeded; null while pending, and for binary tasks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        /// Failure detail when status is failed; otherwise null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// ISO-8601 timestamp of when the job was accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// ISO-8601 timestamp of the last state transition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncJobStatusResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// The job this status describes.
        /// </param>
        /// <param name="status">
        /// Lifecycle state; terminal states are succeeded, failed, cancelled.
        /// </param>
        /// <param name="result">
        /// The task's output once succeeded; null while pending, and for binary tasks.
        /// </param>
        /// <param name="error">
        /// Failure detail when status is failed; otherwise null.
        /// </param>
        /// <param name="createdAt">
        /// ISO-8601 timestamp of when the job was accepted.
        /// </param>
        /// <param name="updatedAt">
        /// ISO-8601 timestamp of the last state transition.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncJobStatusResponse(
            string jobId,
            global::Nixtla.AsyncJobStatus status,
            object? result,
            string? error,
            string? createdAt,
            string? updatedAt)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Status = status;
            this.Result = result;
            this.Error = error;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncJobStatusResponse" /> class.
        /// </summary>
        public AsyncJobStatusResponse()
        {
        }

    }
}