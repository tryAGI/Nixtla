
#nullable enable

namespace Nixtla
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncJobStatus
    {
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Running,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncJobStatus value)
        {
            return value switch
            {
                AsyncJobStatus.Cancelled => "cancelled",
                AsyncJobStatus.Failed => "failed",
                AsyncJobStatus.Pending => "pending",
                AsyncJobStatus.Running => "running",
                AsyncJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => AsyncJobStatus.Cancelled,
                "failed" => AsyncJobStatus.Failed,
                "pending" => AsyncJobStatus.Pending,
                "running" => AsyncJobStatus.Running,
                "succeeded" => AsyncJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}