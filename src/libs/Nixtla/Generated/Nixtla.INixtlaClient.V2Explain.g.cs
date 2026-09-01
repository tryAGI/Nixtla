#nullable enable

namespace Nixtla
{
    public partial interface INixtlaClient
    {
        /// <summary>
        /// Compute model-agnostic feature importance weights<br/>
        /// Compute model-agnostic feature importance weights for the provided exogenous features. It takes a JSON as an input containing the historical data with exogenous features and the attribution method to use. No foundation model is involved. The response contains one normalized weight per feature.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.ExplainOutput> V2ExplainAsync(

            global::Nixtla.ExplainInput request,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compute model-agnostic feature importance weights<br/>
        /// Compute model-agnostic feature importance weights for the provided exogenous features. It takes a JSON as an input containing the historical data with exogenous features and the attribution method to use. No foundation model is involved. The response contains one normalized weight per feature.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AutoSDKHttpResponse<global::Nixtla.ExplainOutput>> V2ExplainAsResponseAsync(

            global::Nixtla.ExplainInput request,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compute model-agnostic feature importance weights<br/>
        /// Compute model-agnostic feature importance weights for the provided exogenous features. It takes a JSON as an input containing the historical data with exogenous features and the attribution method to use. No foundation model is involved. The response contains one normalized weight per feature.
        /// </summary>
        /// <param name="series"></param>
        /// <param name="method">
        /// Model-agnostic causal analysis method used by the /v2/explain endpoint. Options are: 'granger' (default) and 'transfer_entropy'.<br/>
        /// Default Value: granger
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.ExplainOutput> V2ExplainAsync(
            global::Nixtla.SeriesWithExogenous series,
            global::Nixtla.ExplainInputMethod? method = default,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}