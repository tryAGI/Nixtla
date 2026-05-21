#nullable enable

namespace Nixtla
{
    public partial interface INixtlaClient
    {
        /// <summary>
        /// Get single Fine-tuned Model<br/>
        /// Retrieve metadata for a previously fine-tuned model. The response contains the metadata of a model that you have fine-tuned and is available to make forecasts.
        /// </summary>
        /// <param name="finetunedModelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.FinetunedModel> V2FinetunedModelV2FinetunedModelsFinetunedModelIdGetAsync(
            string finetunedModelId,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get single Fine-tuned Model<br/>
        /// Retrieve metadata for a previously fine-tuned model. The response contains the metadata of a model that you have fine-tuned and is available to make forecasts.
        /// </summary>
        /// <param name="finetunedModelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AutoSDKHttpResponse<global::Nixtla.FinetunedModel>> V2FinetunedModelV2FinetunedModelsFinetunedModelIdGetAsResponseAsync(
            string finetunedModelId,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}