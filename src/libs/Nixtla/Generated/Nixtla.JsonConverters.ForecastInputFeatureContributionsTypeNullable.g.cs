#nullable enable

namespace Nixtla.JsonConverters
{
    /// <inheritdoc />
    public sealed class ForecastInputFeatureContributionsTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Nixtla.ForecastInputFeatureContributionsType?>
    {
        /// <inheritdoc />
        public override global::Nixtla.ForecastInputFeatureContributionsType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Nixtla.ForecastInputFeatureContributionsTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Nixtla.ForecastInputFeatureContributionsType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Nixtla.ForecastInputFeatureContributionsType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Nixtla.ForecastInputFeatureContributionsType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Nixtla.ForecastInputFeatureContributionsTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
