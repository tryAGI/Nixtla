
#nullable enable

namespace Nixtla
{
    /// <summary>
    /// Model-agnostic causal analysis method used by the /v2/explain endpoint. Options are: 'granger' (default) and 'transfer_entropy'.<br/>
    /// Default Value: granger
    /// </summary>
    public enum ExplainAsyncRequestMethod
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
    public static class ExplainAsyncRequestMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExplainAsyncRequestMethod value)
        {
            return value switch
            {
                ExplainAsyncRequestMethod.Granger => "granger",
                ExplainAsyncRequestMethod.TransferEntropy => "transfer_entropy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExplainAsyncRequestMethod? ToEnum(string value)
        {
            return value switch
            {
                "granger" => ExplainAsyncRequestMethod.Granger,
                "transfer_entropy" => ExplainAsyncRequestMethod.TransferEntropy,
                _ => null,
            };
        }
    }
}