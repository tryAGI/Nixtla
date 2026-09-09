
#nullable enable

namespace Nixtla
{
    /// <summary>
    /// The loss used to train the large time model on the data. Select from ['default', 'mae', 'mse', 'rmse', 'mape', 'smape', 'poisson']. It will only be used if finetune_steps is larger than 0. Default is a robust loss function that is less sensitive to outliers.<br/>
    /// Default Value: default
    /// </summary>
    public enum AnomalyDetectionAsyncRequestFinetuneLoss
    {
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        Mae,
        /// <summary>
        ///
        /// </summary>
        Mape,
        /// <summary>
        ///
        /// </summary>
        Mse,
        /// <summary>
        ///
        /// </summary>
        Poisson,
        /// <summary>
        ///
        /// </summary>
        Rmse,
        /// <summary>
        ///
        /// </summary>
        Smape,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnomalyDetectionAsyncRequestFinetuneLossExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnomalyDetectionAsyncRequestFinetuneLoss value)
        {
            return value switch
            {
                AnomalyDetectionAsyncRequestFinetuneLoss.Default => "default",
                AnomalyDetectionAsyncRequestFinetuneLoss.Mae => "mae",
                AnomalyDetectionAsyncRequestFinetuneLoss.Mape => "mape",
                AnomalyDetectionAsyncRequestFinetuneLoss.Mse => "mse",
                AnomalyDetectionAsyncRequestFinetuneLoss.Poisson => "poisson",
                AnomalyDetectionAsyncRequestFinetuneLoss.Rmse => "rmse",
                AnomalyDetectionAsyncRequestFinetuneLoss.Smape => "smape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnomalyDetectionAsyncRequestFinetuneLoss? ToEnum(string value)
        {
            return value switch
            {
                "default" => AnomalyDetectionAsyncRequestFinetuneLoss.Default,
                "mae" => AnomalyDetectionAsyncRequestFinetuneLoss.Mae,
                "mape" => AnomalyDetectionAsyncRequestFinetuneLoss.Mape,
                "mse" => AnomalyDetectionAsyncRequestFinetuneLoss.Mse,
                "poisson" => AnomalyDetectionAsyncRequestFinetuneLoss.Poisson,
                "rmse" => AnomalyDetectionAsyncRequestFinetuneLoss.Rmse,
                "smape" => AnomalyDetectionAsyncRequestFinetuneLoss.Smape,
                _ => null,
            };
        }
    }
}