
#nullable enable

namespace Nixtla
{
    /// <summary>
    /// The thresholding method to detect anomalies<br/>
    /// Default Value: univariate
    /// </summary>
    public enum AnomalyDetectionAsyncRequestThresholdMethod
    {
        /// <summary>
        ///
        /// </summary>
        Multivariate,
        /// <summary>
        ///
        /// </summary>
        Univariate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnomalyDetectionAsyncRequestThresholdMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnomalyDetectionAsyncRequestThresholdMethod value)
        {
            return value switch
            {
                AnomalyDetectionAsyncRequestThresholdMethod.Multivariate => "multivariate",
                AnomalyDetectionAsyncRequestThresholdMethod.Univariate => "univariate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnomalyDetectionAsyncRequestThresholdMethod? ToEnum(string value)
        {
            return value switch
            {
                "multivariate" => AnomalyDetectionAsyncRequestThresholdMethod.Multivariate,
                "univariate" => AnomalyDetectionAsyncRequestThresholdMethod.Univariate,
                _ => null,
            };
        }
    }
}