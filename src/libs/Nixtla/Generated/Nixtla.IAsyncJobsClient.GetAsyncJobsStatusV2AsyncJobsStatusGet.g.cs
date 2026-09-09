#nullable enable

namespace Nixtla
{
    public partial interface IAsyncJobsClient
    {
        /// <summary>
        /// Count your team's open async jobs<br/>
        /// Returns your team's open job counts as `{task: {pending, running}}`, with an entry for every async task even when it has no jobs. Only these two states are reported — a succeeded, failed or cancelled job leaves the counts rather than moving between them, so poll a task's status endpoint to see a terminal state. Counts are approximate: they are read from the orchestrator and cached briefly.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::Nixtla.OpenJobCounts>> GetAsyncJobsStatusV2AsyncJobsStatusGetAsync(
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Count your team's open async jobs<br/>
        /// Returns your team's open job counts as `{task: {pending, running}}`, with an entry for every async task even when it has no jobs. Only these two states are reported — a succeeded, failed or cancelled job leaves the counts rather than moving between them, so poll a task's status endpoint to see a terminal state. Counts are approximate: they are read from the orchestrator and cached briefly.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AutoSDKHttpResponse<global::System.Collections.Generic.Dictionary<string, global::Nixtla.OpenJobCounts>>> GetAsyncJobsStatusV2AsyncJobsStatusGetAsResponseAsync(
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}