#nullable enable

namespace Nixtla
{
    public partial interface IAsyncJobsClient
    {
        /// <summary>
        /// List your team's async jobs<br/>
        /// Lists your team's jobs under `jobs` — use it to recover a `job_id` you no longer hold, then poll it on its task's status endpoint or cancel it. Defaults to pending and running; pass `status` (repeatable) for terminal ones, which stay listed only for the orchestrator's retention window. Page with `page_size` and `next_page_token`, continuing until that token is null rather than until a short page: a page can be short, or empty, and still have more behind it. A `page_token` is valid only for the `status` filter it was returned with. Rows are newest first, within a page and across them, so the job you just submitted is at the front of page one.
        /// </summary>
        /// <param name="status">
        /// Job statuses to list. Repeatable. Defaults to pending and running.
        /// </param>
        /// <param name="pageSize">
        /// Maximum rows per page.<br/>
        /// Default Value: 200
        /// </param>
        /// <param name="pageToken">
        /// `next_page_token` from the previous page.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AsyncJobsResponse> ListAsyncJobsV2AsyncJobsGetAsync(
            global::System.Collections.Generic.IList<global::Nixtla.AsyncJobStatus>? status = default,
            int? pageSize = default,
            string? pageToken = default,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List your team's async jobs<br/>
        /// Lists your team's jobs under `jobs` — use it to recover a `job_id` you no longer hold, then poll it on its task's status endpoint or cancel it. Defaults to pending and running; pass `status` (repeatable) for terminal ones, which stay listed only for the orchestrator's retention window. Page with `page_size` and `next_page_token`, continuing until that token is null rather than until a short page: a page can be short, or empty, and still have more behind it. A `page_token` is valid only for the `status` filter it was returned with. Rows are newest first, within a page and across them, so the job you just submitted is at the front of page one.
        /// </summary>
        /// <param name="status">
        /// Job statuses to list. Repeatable. Defaults to pending and running.
        /// </param>
        /// <param name="pageSize">
        /// Maximum rows per page.<br/>
        /// Default Value: 200
        /// </param>
        /// <param name="pageToken">
        /// `next_page_token` from the previous page.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AutoSDKHttpResponse<global::Nixtla.AsyncJobsResponse>> ListAsyncJobsV2AsyncJobsGetAsResponseAsync(
            global::System.Collections.Generic.IList<global::Nixtla.AsyncJobStatus>? status = default,
            int? pageSize = default,
            string? pageToken = default,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}