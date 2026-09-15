#nullable enable

namespace Nixtla
{
    public partial interface INixtlaClient
    {
        /// <summary>
        /// List Models<br/>
        /// List the models available to your API key. Use a returned `name` as the `model` field of a forecast, cross-validation or anomaly-detection request. A model absent here is one those endpoints would reject with 403.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.ModelsResponse> V2ModelsV2ModelsGetAsync(
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Models<br/>
        /// List the models available to your API key. Use a returned `name` as the `model` field of a forecast, cross-validation or anomaly-detection request. A model absent here is one those endpoints would reject with 403.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AutoSDKHttpResponse<global::Nixtla.ModelsResponse>> V2ModelsV2ModelsGetAsResponseAsync(
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}