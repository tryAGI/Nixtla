#nullable enable

namespace Nixtla.JsonConverters
{
    /// <inheritdoc />
    public sealed class FinetuneAsyncRequestFinetuneLossNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Nixtla.FinetuneAsyncRequestFinetuneLoss?>
    {
        /// <inheritdoc />
        public override global::Nixtla.FinetuneAsyncRequestFinetuneLoss? Read(
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
                        return global::Nixtla.FinetuneAsyncRequestFinetuneLossExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Nixtla.FinetuneAsyncRequestFinetuneLoss)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Nixtla.FinetuneAsyncRequestFinetuneLoss?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Nixtla.FinetuneAsyncRequestFinetuneLoss? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Nixtla.FinetuneAsyncRequestFinetuneLossExtensions.ToValueString(value.Value));
            }
        }
    }
}
