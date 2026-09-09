#nullable enable

namespace Nixtla
{
    public partial interface IAsyncJobsClient
    {
        /// <summary>
        /// Submit an async explain job<br/>
        /// Queues a explain job and returns immediately with its `job_id`. The job runs in a sandbox; poll `GET /v2/explain/jobs/{job_id}` for its state and result. Accepts the same body as the synchronous endpoint plus an optional `job_options`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AsyncJobSubmitResponse> V2ExplainAsyncAsync(

            global::Nixtla.ExplainAsyncRequest request,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit an async explain job<br/>
        /// Queues a explain job and returns immediately with its `job_id`. The job runs in a sandbox; poll `GET /v2/explain/jobs/{job_id}` for its state and result. Accepts the same body as the synchronous endpoint plus an optional `job_options`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AutoSDKHttpResponse<global::Nixtla.AsyncJobSubmitResponse>> V2ExplainAsyncAsResponseAsync(

            global::Nixtla.ExplainAsyncRequest request,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit an async explain job<br/>
        /// Queues a explain job and returns immediately with its `job_id`. The job runs in a sandbox; poll `GET /v2/explain/jobs/{job_id}` for its state and result. Accepts the same body as the synchronous endpoint plus an optional `job_options`.
        /// </summary>
        /// <param name="series"></param>
        /// <param name="method">
        /// Model-agnostic causal analysis method used by the /v2/explain endpoint. Options are: 'granger' (default) and 'transfer_entropy'.<br/>
        /// Default Value: granger
        /// </param>
        /// <param name="jobOptions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AsyncJobSubmitResponse> V2ExplainAsyncAsync(
            global::Nixtla.SeriesWithExogenous series,
            global::Nixtla.ExplainAsyncRequestMethod? method = default,
            global::Nixtla.AsyncJobOptions? jobOptions = default,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}