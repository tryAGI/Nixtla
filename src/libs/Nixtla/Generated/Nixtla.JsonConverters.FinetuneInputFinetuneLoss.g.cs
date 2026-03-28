#nullable enable

namespace Nixtla.JsonConverters
{
    /// <inheritdoc />
    public sealed class FinetuneInputFinetuneLossJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Nixtla.FinetuneInputFinetuneLoss>
    {
        /// <inheritdoc />
        public override global::Nixtla.FinetuneInputFinetuneLoss Read(
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
                        return global::Nixtla.FinetuneInputFinetuneLossExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Nixtla.FinetuneInputFinetuneLoss)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Nixtla.FinetuneInputFinetuneLoss);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Nixtla.FinetuneInputFinetuneLoss value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Nixtla.FinetuneInputFinetuneLossExtensions.ToValueString(value));
        }
    }
}
