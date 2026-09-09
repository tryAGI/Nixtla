#nullable enable

namespace Nixtla
{
    public partial interface IAsyncJobsClient
    {
        /// <summary>
        /// Get async execute_step job status<br/>
        /// Returns the current state of an execute_step job. `result` stays null even when `succeeded`, because the output is a zip — fetch it from `GET /v2/execute_step/jobs/{job_id}/result` instead.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AsyncJobStatusResponse> GetExecuteStepJobStatusV2ExecuteStepJobsJobIdGetAsync(
            string jobId,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get async execute_step job status<br/>
        /// Returns the current state of an execute_step job. `result` stays null even when `succeeded`, because the output is a zip — fetch it from `GET /v2/execute_step/jobs/{job_id}/result` instead.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AutoSDKHttpResponse<global::Nixtla.AsyncJobStatusResponse>> GetExecuteStepJobStatusV2ExecuteStepJobsJobIdGetAsResponseAsync(
            string jobId,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}