#nullable enable

namespace Nixtla
{
    public partial interface IExcludedClient
    {
        /// <summary>
        /// Get Model Params
        /// </summary>
        /// <param name="model"></param>
        /// <param name="freq"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetModelParamsModelParamsGetAsync(
            object model,
            string freq,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Model Params
        /// </summary>
        /// <param name="model"></param>
        /// <param name="freq"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AutoSDKHttpResponse<string>> GetModelParamsModelParamsGetAsResponseAsync(
            object model,
            string freq,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}