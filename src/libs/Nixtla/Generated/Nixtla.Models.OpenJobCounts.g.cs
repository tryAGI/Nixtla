
#nullable enable

namespace Nixtla
{
    /// <summary>
    /// How many of one task's jobs are still open.<br/>
    /// Only non-terminal states appear: the orchestrator counts open workflows, so a job that has<br/>
    /// succeeded, failed or been cancelled leaves these counts entirely rather than moving between<br/>
    /// them. Poll the task's status endpoint for a specific job's terminal state.
    /// </summary>
    public sealed partial class OpenJobCounts
    {
        /// <summary>
        /// Accepted but not yet started in a sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Pending { get; set; }

        /// <summary>
        /// Currently executing in a sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Running { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenJobCounts" /> class.
        /// </summary>
        /// <param name="pending">
        /// Accepted but not yet started in a sandbox.
        /// </param>
        /// <param name="running">
        /// Currently executing in a sandbox.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenJobCounts(
            int pending,
            int running)
        {
            this.Pending = pending;
            this.Running = running;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenJobCounts" /> class.
        /// </summary>
        public OpenJobCounts()
        {
        }

    }
}