#nullable enable

namespace Nixtla
{
    public partial interface IAsyncJobsClient
    {
        /// <summary>
        /// Download an async execute_step job result<br/>
        /// Returns the completed step's output as a zip of parquet members, with the sandbox's envelope in the `nixtla-metadata` response header. Valid once the status endpoint reads `succeeded`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetExecuteStepJobResultV2ExecuteStepJobsJobIdResultGetAsync(
            string jobId,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download an async execute_step job result<br/>
        /// Returns the completed step's output as a zip of parquet members, with the sandbox's envelope in the `nixtla-metadata` response header. Valid once the status endpoint reads `succeeded`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetExecuteStepJobResultV2ExecuteStepJobsJobIdResultGetAsStreamAsync(
            string jobId,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download an async execute_step job result<br/>
        /// Returns the completed step's output as a zip of parquet members, with the sandbox's envelope in the `nixtla-metadata` response header. Valid once the status endpoint reads `succeeded`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AutoSDKHttpResponse<byte[]>> GetExecuteStepJobResultV2ExecuteStepJobsJobIdResultGetAsResponseAsync(
            string jobId,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}