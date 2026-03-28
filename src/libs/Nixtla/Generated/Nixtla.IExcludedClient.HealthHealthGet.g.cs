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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthHealthGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}