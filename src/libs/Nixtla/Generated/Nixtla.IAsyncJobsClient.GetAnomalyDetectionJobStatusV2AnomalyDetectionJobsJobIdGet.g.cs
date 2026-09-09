#nullable enable

namespace Nixtla
{
    public partial interface IAsyncJobsClient
    {
        /// <summary>
        /// Get async anomaly_detection job status<br/>
        /// Returns the current state of a anomaly_detection job. `result` is populated once `status` is `succeeded`. A `job_id` belonging to a different task returns 404, so ids cannot be polled across endpoints.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AsyncJobStatusResponse> GetAnomalyDetectionJobStatusV2AnomalyDetectionJobsJobIdGetAsync(
            string jobId,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get async anomaly_detection job status<br/>
        /// Returns the current state of a anomaly_detection job. `result` is populated once `status` is `succeeded`. A `job_id` belonging to a different task returns 404, so ids cannot be polled across endpoints.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AutoSDKHttpResponse<global::Nixtla.AsyncJobStatusResponse>> GetAnomalyDetectionJobStatusV2AnomalyDetectionJobsJobIdGetAsResponseAsync(
            string jobId,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}