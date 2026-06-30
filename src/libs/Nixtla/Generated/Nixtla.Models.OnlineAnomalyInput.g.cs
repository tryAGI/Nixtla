
#nullable enable

namespace Nixtla
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OnlineAnomalyInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Nixtla.SeriesWithFutureExogenous Series { get; set; }

        /// <summary>
        /// The frequency of the data represented as a string. 'D' for daily, 'M' for monthly, 'H' for hourly, and 'W' for weekly frequencies are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freq")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Freq { get; set; }

        /// <summary>
        /// Window over which to detect anomalies starting from the end of the series. This window is not considered when calculating the anomaly threshold to avoid bias from abnormal samples, unless there are less than 6 * detection_size forecasted samples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detection_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DetectionSize { get; set; }

        /// <summary>
        /// The thresholding method to detect anomalies<br/>
        /// Default Value: univariate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Nixtla.JsonConverters.OnlineAnomalyInputThresholdMethodJsonConverter))]
        public global::Nixtla.OnlineAnomalyInputThresholdMethod? ThresholdMethod { get; set; }

        /// <summary>
        /// The forecasting horizon. This represents the number of time steps into the future that the forecast should predict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int H { get; set; }

        /// <summary>
        /// Model to use as a string. Common options are (but not restricted to) `timegpt-1` and `timegpt-1-long-horizon.` Full options vary by different users. Contact support@nixtla.io for more information. We recommend using `timegpt-1-long-horizon` for forecasting if you want to predict more than one seasonal period given the frequency of your data.<br/>
        /// Default Value: timegpt-1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// A boolean flag that indicates whether the API should preprocess (clean) the exogenous signal before applying the large time model. If True, the exogenous signal is cleaned; if False, the exogenous variables are applied after the large time model.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clean_ex_first")]
        public bool? CleanExFirst { get; set; }

        /// <summary>
        /// Specifies the confidence level for the prediction interval used in anomaly detection. It is represented as a percentage between 0 and 100. For instance, a level of 95 indicates that the generated prediction interval captures the true future observation 95% of the time. Any observed values outside of this interval would be considered anomalies. A higher level leads to wider prediction intervals and potentially fewer detected anomalies, whereas a lower level results in narrower intervals and potentially more detected anomalies. Default: 99.<br/>
        /// Default Value: 99
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Nixtla.JsonConverters.AnyOfJsonConverter<int?, double?>))]
        public global::Nixtla.AnyOf<int?, double?>? Level { get; set; }

        /// <summary>
        /// The number of tuning steps used to train the large time model on the data. Set this value to 0 for zero-shot inference, i.e., to make predictions without any further model tuning.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_steps")]
        public int? FinetuneSteps { get; set; }

        /// <summary>
        /// The loss used to train the large time model on the data. Select from ['default', 'mae', 'mse', 'rmse', 'mape', 'smape', 'poisson']. It will only be used if finetune_steps larger than 0. Default is a robust loss function that is less sensitive to outliers.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_loss")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Nixtla.JsonConverters.OnlineAnomalyInputFinetuneLossJsonConverter))]
        public global::Nixtla.OnlineAnomalyInputFinetuneLoss? FinetuneLoss { get; set; }

        /// <summary>
        /// The depth of the finetuning. Uses a scale from 1 to 5, where 1 means little finetuning, and 5 means that the entire model is finetuned. Note that this parameter is only effective for timegpt-1 and timegpt-1-long-horizon models, meanwhile it has no effect on the other models. By default, the value is set to 1.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_depth")]
        public int? FinetuneDepth { get; set; }

        /// <summary>
        /// ID of previously finetuned model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetuned_model_id")]
        public string? FinetunedModelId { get; set; }

        /// <summary>
        /// Step size between each cross validation window. If None it will be equal to the forecasting horizon.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_size")]
        public int? StepSize { get; set; }

        /// <summary>
        /// Zero-based indices of the exogenous features to treat as historical.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hist_exog")]
        public global::System.Collections.Generic.IList<int>? HistExog { get; set; }

        /// <summary>
        /// Fine-tune the model in each window. If `False`, only fine-tunes on the first window. Only used if `finetune_steps` &gt; 0.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refit")]
        public bool? Refit { get; set; }

        /// <summary>
        /// Compute multivariate predictions across a batch of multiple time series. Requires all time series with overlapping dates. Note that this is only effective for timegpt-2.1 model and it has no effect on the other models. By default, the value is set to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multivariate")]
        public bool? Multivariate { get; set; }

        /// <summary>
        /// Optional dictionary of parameters to customize the behavior of the large time model. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_parameters")]
        public object? ModelParameters { get; set; }

        /// <summary>
        /// Compute the exogenous features contributions to the forecast.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature_contributions")]
        public bool? FeatureContributions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineAnomalyInput" /> class.
        /// </summary>
        /// <param name="series"></param>
        /// <param name="freq">
        /// The frequency of the data represented as a string. 'D' for daily, 'M' for monthly, 'H' for hourly, and 'W' for weekly frequencies are available.
        /// </param>
        /// <param name="detectionSize">
        /// Window over which to detect anomalies starting from the end of the series. This window is not considered when calculating the anomaly threshold to avoid bias from abnormal samples, unless there are less than 6 * detection_size forecasted samples.
        /// </param>
        /// <param name="h">
        /// The forecasting horizon. This represents the number of time steps into the future that the forecast should predict.
        /// </param>
        /// <param name="thresholdMethod">
        /// The thresholding method to detect anomalies<br/>
        /// Default Value: univariate
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
        /// Specifies the confidence level for the prediction interval used in anomaly detection. It is represented as a percentage between 0 and 100. For instance, a level of 95 indicates that the generated prediction interval captures the true future observation 95% of the time. Any observed values outside of this interval would be considered anomalies. A higher level leads to wider prediction intervals and potentially fewer detected anomalies, whereas a lower level results in narrower intervals and potentially more detected anomalies. Default: 99.<br/>
        /// Default Value: 99
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OnlineAnomalyInput(
            global::Nixtla.SeriesWithFutureExogenous series,
            string freq,
            int detectionSize,
            int h,
            global::Nixtla.OnlineAnomalyInputThresholdMethod? thresholdMethod,
            string? model,
            bool? cleanExFirst,
            global::Nixtla.AnyOf<int?, double?>? level,
            int? finetuneSteps,
            global::Nixtla.OnlineAnomalyInputFinetuneLoss? finetuneLoss,
            int? finetuneDepth,
            string? finetunedModelId,
            int? stepSize,
            global::System.Collections.Generic.IList<int>? histExog,
            bool? refit,
            bool? multivariate,
            object? modelParameters,
            bool? featureContributions)
        {
            this.Series = series ?? throw new global::System.ArgumentNullException(nameof(series));
            this.Freq = freq ?? throw new global::System.ArgumentNullException(nameof(freq));
            this.DetectionSize = detectionSize;
            this.ThresholdMethod = thresholdMethod;
            this.H = h;
            this.Model = model;
            this.CleanExFirst = cleanExFirst;
            this.Level = level;
            this.FinetuneSteps = finetuneSteps;
            this.FinetuneLoss = finetuneLoss;
            this.FinetuneDepth = finetuneDepth;
            this.FinetunedModelId = finetunedModelId;
            this.StepSize = stepSize;
            this.HistExog = histExog;
            this.Refit = refit;
            this.Multivariate = multivariate;
            this.ModelParameters = modelParameters;
            this.FeatureContributions = featureContributions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineAnomalyInput" /> class.
        /// </summary>
        public OnlineAnomalyInput()
        {
        }

    }
}