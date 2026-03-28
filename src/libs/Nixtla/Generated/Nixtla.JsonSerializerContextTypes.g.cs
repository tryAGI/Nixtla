
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Nixtla
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.AnomalyDetectionInput? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.SeriesWithExogenous? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.AnyOf<int?, double?>? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.AnomalyDetectionOutput? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<bool>? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.CrossValidationInput? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Nixtla.AnyOf<int?, double?>>? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.CrossValidationInputFinetuneLoss? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.CrossValidationOutput? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.FinetuneInput? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.Series? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.FinetuneInputFinetuneLoss? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.FinetuneOutput? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.FinetunedModel? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.FinetunedModelLoss? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.FinetunedModelsOutput? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Nixtla.FinetunedModel>? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.ForecastInput? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.SeriesWithFutureExogenous? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.ForecastInputFinetuneLoss? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.ForecastOutput? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.HTTPValidationError? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Nixtla.ValidationError>? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.ValidationError? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.InSampleInput? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.InSampleOutput? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.MultiSeriesAnomaly? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.MultiSeriesInput? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.MultiSeriesCrossValidation? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.MultiSeriesCrossValidationFewshotLoss2? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.MultiSeriesCrossValidationFinetuneLoss? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.MultiSeriesForecast? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.MultiSeriesForecastFewshotLoss2? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.MultiSeriesForecastFinetuneLoss? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.MultiSeriesInsampleForecast? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.OnlineAnomalyInput? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.OnlineAnomalyInputThresholdMethod? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.OnlineAnomalyInputFinetuneLoss? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.OnlineAnomalyOutput? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.SingleSeriesForecast? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.SingleSeriesForecastFewshotLoss2? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.SingleSeriesForecastFinetuneLoss? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.SingleSeriesInsampleForecast? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Nixtla.AnyOf<string, int?>>? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Nixtla.AnyOf<string, int?>? Type55 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<double>>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<bool>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Nixtla.AnyOf<int?, double?>>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Nixtla.FinetunedModel>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Nixtla.ValidationError>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Nixtla.AnyOf<string, int?>>? ListType10 { get; set; }
    }
}