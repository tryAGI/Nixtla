#nullable enable

namespace Nixtla.JsonConverters
{
    /// <inheritdoc />
    public sealed class ForecastAsyncRequestFeatureContributionsTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Nixtla.ForecastAsyncRequestFeatureContributionsType?>
    {
        /// <inheritdoc />
        public override global::Nixtla.ForecastAsyncRequestFeatureContributionsType? Read(
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
                        return global::Nixtla.ForecastAsyncRequestFeatureContributionsTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Nixtla.ForecastAsyncRequestFeatureContributionsType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Nixtla.ForecastAsyncRequestFeatureContributionsType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Nixtla.ForecastAsyncRequestFeatureContributionsType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Nixtla.ForecastAsyncRequestFeatureContributionsTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
