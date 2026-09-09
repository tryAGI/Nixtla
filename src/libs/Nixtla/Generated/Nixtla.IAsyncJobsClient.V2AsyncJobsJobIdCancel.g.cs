#nullable enable

namespace Nixtla
{
    public partial interface IAsyncJobsClient
    {
        /// <summary>
        /// Cancel an async job<br/>
        /// Requests cancellation of any async job by `job_id`, whatever its task. Accepting the request does not guarantee the job stopped — poll the task's status endpoint until it reads `cancelled`. An unknown or foreign `job_id` returns 404.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AsyncJobSubmitResponse> V2AsyncJobsJobIdCancelAsync(
            string jobId,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel an async job<br/>
        /// Requests cancellation of any async job by `job_id`, whatever its task. Accepting the request does not guarantee the job stopped — poll the task's status endpoint until it reads `cancelled`. An unknown or foreign `job_id` returns 404.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AutoSDKHttpResponse<global::Nixtla.AsyncJobSubmitResponse>> V2AsyncJobsJobIdCancelAsResponseAsync(
            string jobId,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}