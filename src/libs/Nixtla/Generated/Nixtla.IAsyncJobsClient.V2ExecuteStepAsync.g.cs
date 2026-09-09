#nullable enable

namespace Nixtla
{
    public partial interface IAsyncJobsClient
    {
        /// <summary>
        /// Submit an async execute_step job<br/>
        /// Queues an execute_step job and returns immediately with its `job_id`. The body is a zip of parquet members and the call parameters travel in the `nixtla-metadata` header, not as JSON. Poll `GET /v2/execute_step/jobs/{job_id}` for its state, then fetch the zip from `/result` once it reads `succeeded`.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AsyncJobSubmitResponse> V2ExecuteStepAsyncAsync(
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit an async execute_step job<br/>
        /// Queues an execute_step job and returns immediately with its `job_id`. The body is a zip of parquet members and the call parameters travel in the `nixtla-metadata` header, not as JSON. Poll `GET /v2/execute_step/jobs/{job_id}` for its state, then fetch the zip from `/result` once it reads `succeeded`.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AutoSDKHttpResponse<global::Nixtla.AsyncJobSubmitResponse>> V2ExecuteStepAsyncAsResponseAsync(
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}