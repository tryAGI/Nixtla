
#nullable enable

namespace Nixtla
{
    /// <summary>
    /// The body of `GET /v2/async/jobs`.<br/>
    /// An object rather than a bare array, matching the rest of the `v2` family, so a new field is not<br/>
    /// a shape change.
    /// </summary>
    public sealed partial class AsyncJobsResponse
    {
        /// <summary>
        /// One page of the team's jobs, newest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Nixtla.AsyncJobSummary> Jobs { get; set; }

        /// <summary>
        /// Cursor for the next page, or null on the last one. Page until this is null, not until a short page — a page can be short, or empty, and still have more behind it. Valid only for the `status` filter it was returned with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncJobsResponse" /> class.
        /// </summary>
        /// <param name="jobs">
        /// One page of the team's jobs, newest first.
        /// </param>
        /// <param name="nextPageToken">
        /// Cursor for the next page, or null on the last one. Page until this is null, not until a short page — a page can be short, or empty, and still have more behind it. Valid only for the `status` filter it was returned with.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncJobsResponse(
            global::System.Collections.Generic.IList<global::Nixtla.AsyncJobSummary> jobs,
            string? nextPageToken)
        {
            this.Jobs = jobs ?? throw new global::System.ArgumentNullException(nameof(jobs));
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncJobsResponse" /> class.
        /// </summary>
        public AsyncJobsResponse()
        {
        }

    }
}