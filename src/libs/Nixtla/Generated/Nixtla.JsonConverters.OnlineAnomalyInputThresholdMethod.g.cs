#nullable enable

namespace Nixtla.JsonConverters
{
    /// <inheritdoc />
    public sealed class OnlineAnomalyInputThresholdMethodJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Nixtla.OnlineAnomalyInputThresholdMethod>
    {
        /// <inheritdoc />
        public override global::Nixtla.OnlineAnomalyInputThresholdMethod Read(
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
                        return global::Nixtla.OnlineAnomalyInputThresholdMethodExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Nixtla.OnlineAnomalyInputThresholdMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Nixtla.OnlineAnomalyInputThresholdMethod);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Nixtla.OnlineAnomalyInputThresholdMethod value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Nixtla.OnlineAnomalyInputThresholdMethodExtensions.ToValueString(value));
        }
    }
}
