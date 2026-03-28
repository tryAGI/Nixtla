#nullable enable

namespace Nixtla.JsonConverters
{
    /// <inheritdoc />
    public sealed class MultiSeriesCrossValidationFinetuneLossNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Nixtla.MultiSeriesCrossValidationFinetuneLoss?>
    {
        /// <inheritdoc />
        public override global::Nixtla.MultiSeriesCrossValidationFinetuneLoss? Read(
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
                        return global::Nixtla.MultiSeriesCrossValidationFinetuneLossExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Nixtla.MultiSeriesCrossValidationFinetuneLoss)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Nixtla.MultiSeriesCrossValidationFinetuneLoss?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Nixtla.MultiSeriesCrossValidationFinetuneLoss? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Nixtla.MultiSeriesCrossValidationFinetuneLossExtensions.ToValueString(value.Value));
            }
        }
    }
}
