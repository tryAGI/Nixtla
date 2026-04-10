#nullable enable

namespace Nixtla
{
    public partial interface INixtlaClient
    {
        /// <summary>
        /// List Fine-tuned Models<br/>
        /// List all the finetuned models that you have created. The response contains a list with the IDs of the models that you have fine-tuned and are available to make forecasts.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.FinetunedModelsOutput> V2FinetunedModelsV2FinetunedModelsGetAsync(
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}