#nullable enable

namespace Nixtla
{
    public partial interface INixtlaClient
    {
        /// <summary>
        /// Delete Fine-tuned Model<br/>
        /// Delete a previously saved finetuned model. It takes the ID of the model that you want to delete as a path parameter.
        /// </summary>
        /// <param name="finetunedModelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task V2FinetunedModelsDeleteV2FinetunedModelsFinetunedModelIdDeleteAsync(
            string finetunedModelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}