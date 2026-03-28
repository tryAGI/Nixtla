
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Nixtla
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Nixtla.JsonConverters.CrossValidationInputFinetuneLossJsonConverter),

            typeof(global::Nixtla.JsonConverters.CrossValidationInputFinetuneLossNullableJsonConverter),

            typeof(global::Nixtla.JsonConverters.FinetuneInputFinetuneLossJsonConverter),

            typeof(global::Nixtla.JsonConverters.FinetuneInputFinetuneLossNullableJsonConverter),

            typeof(global::Nixtla.JsonConverters.FinetunedModelLossJsonConverter),

            typeof(global::Nixtla.JsonConverters.FinetunedModelLossNullableJsonConverter),

            typeof(global::Nixtla.JsonConverters.ForecastInputFinetuneLossJsonConverter),

            typeof(global::Nixtla.JsonConverters.ForecastInputFinetuneLossNullableJsonConverter),

            typeof(global::Nixtla.JsonConverters.MultiSeriesCrossValidationFewshotLoss2JsonConverter),

            typeof(global::Nixtla.JsonConverters.MultiSeriesCrossValidationFewshotLoss2NullableJsonConverter),

            typeof(global::Nixtla.JsonConverters.MultiSeriesCrossValidationFinetuneLossJsonConverter),

            typeof(global::Nixtla.JsonConverters.MultiSeriesCrossValidationFinetuneLossNullableJsonConverter),

            typeof(global::Nixtla.JsonConverters.MultiSeriesForecastFewshotLoss2JsonConverter),

            typeof(global::Nixtla.JsonConverters.MultiSeriesForecastFewshotLoss2NullableJsonConverter),

            typeof(global::Nixtla.JsonConverters.MultiSeriesForecastFinetuneLossJsonConverter),

            typeof(global::Nixtla.JsonConverters.MultiSeriesForecastFinetuneLossNullableJsonConverter),

            typeof(global::Nixtla.JsonConverters.OnlineAnomalyInputThresholdMethodJsonConverter),

            typeof(global::Nixtla.JsonConverters.OnlineAnomalyInputThresholdMethodNullableJsonConverter),

            typeof(global::Nixtla.JsonConverters.OnlineAnomalyInputFinetuneLossJsonConverter),

            typeof(global::Nixtla.JsonConverters.OnlineAnomalyInputFinetuneLossNullableJsonConverter),

            typeof(global::Nixtla.JsonConverters.SingleSeriesForecastFewshotLoss2JsonConverter),

            typeof(global::Nixtla.JsonConverters.SingleSeriesForecastFewshotLoss2NullableJsonConverter),

            typeof(global::Nixtla.JsonConverters.SingleSeriesForecastFinetuneLossJsonConverter),

            typeof(global::Nixtla.JsonConverters.SingleSeriesForecastFinetuneLossNullableJsonConverter),

            typeof(global::Nixtla.JsonConverters.AnyOfJsonConverter<int?, double?>),

            typeof(global::Nixtla.JsonConverters.AnyOfJsonConverter<int?, double?>),

            typeof(global::Nixtla.JsonConverters.AnyOfJsonConverter<int?, double?>),

            typeof(global::Nixtla.JsonConverters.AnyOfJsonConverter<int?, double?>),

            typeof(global::Nixtla.JsonConverters.AnyOfJsonConverter<int?, double?>),

            typeof(global::Nixtla.JsonConverters.AnyOfJsonConverter<int?, double?>),

            typeof(global::Nixtla.JsonConverters.AnyOfJsonConverter<int?, double?>),

            typeof(global::Nixtla.JsonConverters.AnyOfJsonConverter<int?, double?>),

            typeof(global::Nixtla.JsonConverters.AnyOfJsonConverter<int?, double?>),

            typeof(global::Nixtla.JsonConverters.AnyOfJsonConverter<int?, double?>),

            typeof(global::Nixtla.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Nixtla.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.AnomalyDetectionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.SeriesWithExogenous))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.AnyOf<int?, double?>), TypeInfoPropertyName = "AnyOfInt32Double2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.AnomalyDetectionOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.CrossValidationInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Nixtla.AnyOf<int?, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.CrossValidationInputFinetuneLoss), TypeInfoPropertyName = "CrossValidationInputFinetuneLoss2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.CrossValidationOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.FinetuneInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.Series))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.FinetuneInputFinetuneLoss), TypeInfoPropertyName = "FinetuneInputFinetuneLoss2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.FinetuneOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.FinetunedModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.FinetunedModelLoss), TypeInfoPropertyName = "FinetunedModelLoss2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.FinetunedModelsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Nixtla.FinetunedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.ForecastInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.SeriesWithFutureExogenous))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.ForecastInputFinetuneLoss), TypeInfoPropertyName = "ForecastInputFinetuneLoss2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.ForecastOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Nixtla.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.InSampleInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.InSampleOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.MultiSeriesAnomaly))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.MultiSeriesInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.MultiSeriesCrossValidation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.MultiSeriesCrossValidationFewshotLoss2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.MultiSeriesCrossValidationFinetuneLoss), TypeInfoPropertyName = "MultiSeriesCrossValidationFinetuneLoss2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.MultiSeriesForecast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.MultiSeriesForecastFewshotLoss2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.MultiSeriesForecastFinetuneLoss), TypeInfoPropertyName = "MultiSeriesForecastFinetuneLoss2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.MultiSeriesInsampleForecast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.OnlineAnomalyInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.OnlineAnomalyInputThresholdMethod), TypeInfoPropertyName = "OnlineAnomalyInputThresholdMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.OnlineAnomalyInputFinetuneLoss), TypeInfoPropertyName = "OnlineAnomalyInputFinetuneLoss2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.OnlineAnomalyOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.SingleSeriesForecast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.SingleSeriesForecastFewshotLoss2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.SingleSeriesForecastFinetuneLoss), TypeInfoPropertyName = "SingleSeriesForecastFinetuneLoss2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.SingleSeriesInsampleForecast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Nixtla.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nixtla.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Nixtla.AnyOf<int?, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Nixtla.FinetunedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Nixtla.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Nixtla.AnyOf<string, int?>>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}