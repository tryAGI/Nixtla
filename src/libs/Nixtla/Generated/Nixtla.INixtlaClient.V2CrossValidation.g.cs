#nullable enable

namespace Nixtla
{
    public partial interface INixtlaClient
    {
        /// <summary>
        /// Foundational Time Series Model Multi Series Cross Validation<br/>
        /// Perform Cross Validation for multiple series
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.CrossValidationOutput> V2CrossValidationAsync(

            global::Nixtla.CrossValidationInput request,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Foundational Time Series Model Multi Series Cross Validation<br/>
        /// Perform Cross Validation for multiple series
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nixtla.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.AutoSDKHttpResponse<global::Nixtla.CrossValidationOutput>> V2CrossValidationAsResponseAsync(

            global::Nixtla.CrossValidationInput request,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Foundational Time Series Model Multi Series Cross Validation<br/>
        /// Perform Cross Validation for multiple series
        /// </summary>
        /// <param name="series"></param>
        /// <param name="freq">
        /// The frequency of the data represented as a string. 'D' for daily, 'M' for monthly, 'H' for hourly, and 'W' for weekly frequencies are available.
        /// </param>
        /// <param name="nWindows">
        /// Number of windows to evaluate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="h">
        /// The forecasting horizon. This represents the number of time steps into the future that the forecast should predict.
        /// </param>
        /// <param name="fullHistory">
        /// Forecast across the entire series history (the `add_history` use case). The horizon and number of windows are derived server-side (any supplied `h` / `n_windows` are ignored), and the exogenous model is refit a bounded number of times to keep whole-history requests fast. Has no effect without exogenous features.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="model">
        /// Model to use as a string. Common options are (but not restricted to) `timegpt-1` and `timegpt-1-long-horizon.` Full options vary by different users. Contact support@nixtla.io for more information. We recommend using `timegpt-1-long-horizon` for forecasting if you want to predict more than one seasonal period given the frequency of your data.<br/>
        /// Default Value: timegpt-1
        /// </param>
        /// <param name="cleanExFirst">
        /// A boolean flag that indicates whether the API should preprocess (clean) the exogenous signal before applying the large time model. If True, the exogenous signal is cleaned; if False, the exogenous variables are applied after the large time model.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="level">
        /// A list of values representing the prediction intervals. Each value is a percentage that indicates the level of certainty for the corresponding prediction interval. For example, [80, 90] defines 80% and 90% prediction intervals.
        /// </param>
        /// <param name="finetuneSteps">
        /// The number of tuning steps used to train the large time model on the data. Set this value to 0 for zero-shot inference, i.e., to make predictions without any further model tuning.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="finetuneLoss">
        /// The loss used to train the large time model on the data. Select from ['default', 'mae', 'mse', 'rmse', 'mape', 'smape', 'poisson']. It will only be used if finetune_steps larger than 0. Default is a robust loss function that is less sensitive to outliers.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="finetuneDepth">
        /// The depth of the finetuning. Uses a scale from 1 to 5, where 1 means little finetuning, and 5 means that the entire model is finetuned. Note that this parameter is only effective for timegpt-1 and timegpt-1-long-horizon models, meanwhile it has no effect on the other models. By default, the value is set to 1.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="finetunedModelId">
        /// ID of previously finetuned model
        /// </param>
        /// <param name="stepSize">
        /// Step size between each cross validation window. If None it will be equal to the forecasting horizon.
        /// </param>
        /// <param name="histExog">
        /// Zero-based indices of the exogenous features to treat as historical.
        /// </param>
        /// <param name="refit">
        /// Fine-tune the model in each window. If `False`, only fine-tunes on the first window. Only used if `finetune_steps` &gt; 0.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="multivariate">
        /// Compute multivariate predictions across a batch of multiple time series. Requires all time series with overlapping dates. Note that this is only effective for timegpt-2.1 model and it has no effect on the other models. By default, the value is set to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="modelParameters">
        /// Optional dictionary of parameters to customize the behavior of the large time model. 
        /// </param>
        /// <param name="featureContributions">
        /// Compute the exogenous features contributions to the forecast.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Nixtla.CrossValidationOutput> V2CrossValidationAsync(
            global::Nixtla.SeriesWithFutureExogenous series,
            string freq,
            int h,
            int? nWindows = default,
            bool? fullHistory = default,
            string? model = default,
            bool? cleanExFirst = default,
            global::System.Collections.Generic.IList<global::Nixtla.AnyOf<int?, double?>>? level = default,
            int? finetuneSteps = default,
            global::Nixtla.CrossValidationInputFinetuneLoss? finetuneLoss = default,
            int? finetuneDepth = default,
            string? finetunedModelId = default,
            int? stepSize = default,
            global::System.Collections.Generic.IList<int>? histExog = default,
            bool? refit = default,
            bool? multivariate = default,
            object? modelParameters = default,
            bool? featureContributions = default,
            global::Nixtla.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}