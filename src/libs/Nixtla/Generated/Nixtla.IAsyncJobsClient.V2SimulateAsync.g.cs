#nullable enable

namespace Nixtla
{
    public partial interface IAsyncJobsClient
    {
        /// <summary>
        /// Submit an async simulate job<br/>
        /// Queues a simulate job and returns immediately with its `job_id`. The job runs in a sandbox; poll `GET /v2/simulate/jobs/{job_id}` for its state and result. Accepts the same body as the synchronous endpoint plus an optional `job_options`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AsyncJobSubmitResponse> V2SimulateAsyncAsync(

            global::Nixtla.SimulateAsyncRequest request,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit an async simulate job<br/>
        /// Queues a simulate job and returns immediately with its `job_id`. The job runs in a sandbox; poll `GET /v2/simulate/jobs/{job_id}` for its state and result. Accepts the same body as the synchronous endpoint plus an optional `job_options`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AutoSDKHttpResponse<global::Nixtla.AsyncJobSubmitResponse>> V2SimulateAsyncAsResponseAsync(

            global::Nixtla.SimulateAsyncRequest request,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit an async simulate job<br/>
        /// Queues a simulate job and returns immediately with its `job_id`. The job runs in a sandbox; poll `GET /v2/simulate/jobs/{job_id}` for its state and result. Accepts the same body as the synchronous endpoint plus an optional `job_options`.
        /// </summary>
        /// <param name="series"></param>
        /// <param name="freq">
        /// The frequency of the data represented as a string. 'D' for daily, 'M' for monthly, 'H' for hourly, and 'W' for weekly frequencies are available.
        /// </param>
        /// <param name="h">
        /// The forecasting horizon. This represents the number of time steps into the future that the forecast should predict.
        /// </param>
        /// <param name="model">
        /// Model to use as a string. Common options are (but not restricted to) `timegpt-1` and `timegpt-1-long-horizon`. Full options vary by different users. Contact support@nixtla.io for more information. We recommend using `timegpt-1-long-horizon` for forecasting if you want to predict more than one seasonal period given the frequency of your data.<br/>
        /// Default Value: timegpt-1
        /// </param>
        /// <param name="finetunedModelId">
        /// ID of previously finetuned model
        /// </param>
        /// <param name="cleanExFirst">
        /// A boolean flag that indicates whether the API should preprocess (clean) the exogenous signal before applying the large time model. If True, the exogenous signal is cleaned; if False, the exogenous variables are applied after the large time model.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="multivariate">
        /// When True, sample paths are coupled across series via a shared-template Schaake shuffle (path k reflects the same historical period for every series) — this applies to ALL models. Falls back to independent per-series paths when no NaN-free shared history window exists (see `coupled` in the response). Also enables the multivariate marginal forecast for models that support it (timegpt-2.1).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="nPaths">
        /// Number of sample paths to generate per series.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="quantiles">
        /// Marginal quantile grid in (0, 1), strictly increasing, length in [2, 200]. Defaults to the model's native grid (native-quantile losses) or a dense grid (point-loss/conformal).
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility. When omitted, a fresh random seed is drawn, so repeated unseeded requests return different paths.
        /// </param>
        /// <param name="jobOptions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AsyncJobSubmitResponse> V2SimulateAsyncAsync(
            global::Nixtla.SeriesWithFutureExogenous series,
            string freq,
            int h,
            string? model = default,
            string? finetunedModelId = default,
            bool? cleanExFirst = default,
            bool? multivariate = default,
            int? nPaths = default,
            global::System.Collections.Generic.IList<double>? quantiles = default,
            int? seed = default,
            global::Nixtla.AsyncJobOptions? jobOptions = default,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}