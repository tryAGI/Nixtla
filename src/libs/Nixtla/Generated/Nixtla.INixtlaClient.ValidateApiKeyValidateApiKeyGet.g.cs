#nullable enable

namespace Nixtla
{
    public partial interface INixtlaClient
    {
        /// <summary>
        /// Validate Api Key
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ValidateApiKeyValidateApiKeyGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}