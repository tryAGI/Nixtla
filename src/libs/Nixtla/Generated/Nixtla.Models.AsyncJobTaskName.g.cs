
#nullable enable

namespace Nixtla
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncJobTaskName
    {
        /// <summary>
        ///
        /// </summary>
        AnomalyDetection,
        /// <summary>
        ///
        /// </summary>
        CrossValidation,
        /// <summary>
        ///
        /// </summary>
        ExecuteStep,
        /// <summary>
        ///
        /// </summary>
        Explain,
        /// <summary>
        ///
        /// </summary>
        Finetune,
        /// <summary>
        ///
        /// </summary>
        Forecast,
        /// <summary>
        ///
        /// </summary>
        Simulate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncJobTaskNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncJobTaskName value)
        {
            return value switch
            {
                AsyncJobTaskName.AnomalyDetection => "anomaly_detection",
                AsyncJobTaskName.CrossValidation => "cross_validation",
                AsyncJobTaskName.ExecuteStep => "execute_step",
                AsyncJobTaskName.Explain => "explain",
                AsyncJobTaskName.Finetune => "finetune",
                AsyncJobTaskName.Forecast => "forecast",
                AsyncJobTaskName.Simulate => "simulate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncJobTaskName? ToEnum(string value)
        {
            return value switch
            {
                "anomaly_detection" => AsyncJobTaskName.AnomalyDetection,
                "cross_validation" => AsyncJobTaskName.CrossValidation,
                "execute_step" => AsyncJobTaskName.ExecuteStep,
                "explain" => AsyncJobTaskName.Explain,
                "finetune" => AsyncJobTaskName.Finetune,
                "forecast" => AsyncJobTaskName.Forecast,
                "simulate" => AsyncJobTaskName.Simulate,
                _ => null,
            };
        }
    }
}