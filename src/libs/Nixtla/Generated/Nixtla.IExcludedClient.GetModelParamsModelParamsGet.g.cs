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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetModelParamsModelParamsGetAsync(
            object model,
            string freq,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}