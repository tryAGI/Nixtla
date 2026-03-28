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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.FinetunedModel> V2FinetunedModelV2FinetunedModelsFinetunedModelIdGetAsync(
            string finetunedModelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}