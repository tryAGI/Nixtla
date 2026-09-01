
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
        public global::Nixtla.OnlineAnomalyInput? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.OnlineAnomalyInputThresholdMethod? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.OnlineAnomalyInputFinetuneLoss? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.OnlineAnomalyOutput? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Nixtla.AnyOf<double?, string>>>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Nixtla.AnyOf<double?, string>>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.AnyOf<double?, string>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Nixtla.AnyOf<string, int?>>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nixtla.AnyOf<string, int?>? Type46 { get; set; }

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
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Nixtla.AnyOf<double?, string>>>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Nixtla.AnyOf<double?, string>>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Nixtla.AnyOf<string, int?>>? ListType11 { get; set; }
    }
}