
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
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

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
        public global::Nixtla.SeriesWithFutureExogenous? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.AnyOf<int?, double?>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.AnomalyDetectionOutput? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<bool>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.CrossValidationInput? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Nixtla.AnyOf<int?, double?>>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.CrossValidationInputFinetuneLoss? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.CrossValidationInputFeatureContributionsType? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.CrossValidationOutput? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.ExplainInput? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.SeriesWithExogenous? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.ExplainInputMethod? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.ExplainOutput? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.FinetuneInput? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.FinetuneInputFinetuneLoss? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.FinetuneOutput? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.FinetunedModel? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.FinetunedModelLoss? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.FinetunedModelsOutput? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Nixtla.FinetunedModel>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.ForecastInput? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.ForecastInputFinetuneLoss? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.ForecastInputFeatureContributionsType? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.ForecastOutput? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.HTTPValidationError? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Nixtla.ValidationError>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.ValidationError? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.ModelInfo? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.ModelsResponse? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Nixtla.ModelInfo>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.OnlineAnomalyInput? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.OnlineAnomalyInputThresholdMethod? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.OnlineAnomalyInputFinetuneLoss? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.OnlineAnomalyOutput? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Nixtla.AnyOf<double?, string>>>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Nixtla.AnyOf<double?, string>>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.AnyOf<double?, string>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Nixtla.AnyOf<string, int?>>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.AnyOf<string, int?>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.AnomalyDetectionAsyncRequest? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.AnomalyDetectionAsyncRequestThresholdMethod? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.AnomalyDetectionAsyncRequestFinetuneLoss? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.AsyncJobOptions? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.AsyncJobStatus? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.AsyncJobStatusResponse? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.AsyncJobSubmitResponse? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.AsyncJobSummary? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.AsyncJobTaskName? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.AsyncJobsResponse? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Nixtla.AsyncJobSummary>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.CrossValidationAsyncRequest? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.CrossValidationAsyncRequestFinetuneLoss? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.CrossValidationAsyncRequestFeatureContributionsType? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.ExplainAsyncRequest? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.ExplainAsyncRequestMethod? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.FinetuneAsyncRequest? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.FinetuneAsyncRequestFinetuneLoss? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.ForecastAsyncRequest? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.ForecastAsyncRequestFinetuneLoss? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.ForecastAsyncRequestFeatureContributionsType? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.SimulateAsyncRequest? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Nixtla.AsyncJobStatus>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type73 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<double>>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<bool>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Nixtla.AnyOf<int?, double?>>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Nixtla.FinetunedModel>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Nixtla.ValidationError>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Nixtla.ModelInfo>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Nixtla.AnyOf<double?, string>>>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Nixtla.AnyOf<double?, string>>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Nixtla.AnyOf<string, int?>>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Nixtla.AsyncJobSummary>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Nixtla.AsyncJobStatus>? ListType14 { get; set; }
    }
}