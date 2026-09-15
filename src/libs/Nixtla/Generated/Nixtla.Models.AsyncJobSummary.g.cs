
#nullable enable

namespace Nixtla
{
    /// <summary>
    /// One job, as the listing endpoint names it.<br/>
    /// A terminal job stays listed only for the orchestrator's retention window, so a row's absence is<br/>
    /// not evidence it never existed. Carries no result — poll the task's status endpoint for that.
    /// </summary>
    public sealed partial class AsyncJobSummary
    {
        /// <summary>
        /// Identifier for the job, usable on its task's status endpoint and on cancel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Which async task this job runs; null only if the `job_id` carries no recognised prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_name")]
        public global::Nixtla.AsyncJobTaskName? TaskName { get; set; }

        /// <summary>
        /// Lifecycle state; terminal states are succeeded, failed, cancelled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Nixtla.JsonConverters.AsyncJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Nixtla.AsyncJobStatus Status { get; set; }

        /// <summary>
        /// ISO-8601 timestamp of when the job was accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncJobSummary" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Identifier for the job, usable on its task's status endpoint and on cancel.
        /// </param>
        /// <param name="status">
        /// Lifecycle state; terminal states are succeeded, failed, cancelled.
        /// </param>
        /// <param name="createdAt">
        /// ISO-8601 timestamp of when the job was accepted.
        /// </param>
        /// <param name="taskName">
        /// Which async task this job runs; null only if the `job_id` carries no recognised prefix.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncJobSummary(
            string jobId,
            global::Nixtla.AsyncJobStatus status,
            string createdAt,
            global::Nixtla.AsyncJobTaskName? taskName)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.TaskName = taskName;
            this.Status = status;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncJobSummary" /> class.
        /// </summary>
        public AsyncJobSummary()
        {
        }

    }
}