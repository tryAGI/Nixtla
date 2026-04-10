#nullable enable

namespace Nixtla
{
    public partial interface IExcludedClient
    {
        /// <summary>
        /// Health<br/>
        /// Check if server is healthy.<br/>
        /// Used by the readiness probe to check server is healthy.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthHealthGetAsync(
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}