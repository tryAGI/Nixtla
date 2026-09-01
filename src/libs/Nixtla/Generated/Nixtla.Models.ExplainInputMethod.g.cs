
#nullable enable

namespace Nixtla
{
    /// <summary>
    /// Model-agnostic causal analysis method used by the /v2/explain endpoint. Options are: 'granger' (default) and 'transfer_entropy'.<br/>
    /// Default Value: granger
    /// </summary>
    public enum ExplainInputMethod
    {
        /// <summary>
        /// 'granger' (default) and 'transfer_entropy'.
        /// </summary>
        Granger,
        /// <summary>
        /// 'granger' (default) and 'transfer_entropy'.
        /// </summary>
        TransferEntropy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExplainInputMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExplainInputMethod value)
        {
            return value switch
            {
                ExplainInputMethod.Granger => "granger",
                ExplainInputMethod.TransferEntropy => "transfer_entropy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExplainInputMethod? ToEnum(string value)
        {
            return value switch
            {
                "granger" => ExplainInputMethod.Granger,
                "transfer_entropy" => ExplainInputMethod.TransferEntropy,
                _ => null,
            };
        }
    }
}