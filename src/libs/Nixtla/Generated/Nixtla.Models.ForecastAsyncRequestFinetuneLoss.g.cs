
#nullable enable

namespace Nixtla
{
    /// <summary>
    /// The loss used to train the large time model on the data. Select from ['default', 'mae', 'mse', 'rmse', 'mape', 'smape', 'poisson']. It will only be used if finetune_steps is larger than 0. Default is a robust loss function that is less sensitive to outliers.<br/>
    /// Default Value: default
    /// </summary>
    public enum ForecastAsyncRequestFinetuneLoss
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
    public static class ForecastAsyncRequestFinetuneLossExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ForecastAsyncRequestFinetuneLoss value)
        {
            return value switch
            {
                ForecastAsyncRequestFinetuneLoss.Default => "default",
                ForecastAsyncRequestFinetuneLoss.Mae => "mae",
                ForecastAsyncRequestFinetuneLoss.Mape => "mape",
                ForecastAsyncRequestFinetuneLoss.Mse => "mse",
                ForecastAsyncRequestFinetuneLoss.Poisson => "poisson",
                ForecastAsyncRequestFinetuneLoss.Rmse => "rmse",
                ForecastAsyncRequestFinetuneLoss.Smape => "smape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ForecastAsyncRequestFinetuneLoss? ToEnum(string value)
        {
            return value switch
            {
                "default" => ForecastAsyncRequestFinetuneLoss.Default,
                "mae" => ForecastAsyncRequestFinetuneLoss.Mae,
                "mape" => ForecastAsyncRequestFinetuneLoss.Mape,
                "mse" => ForecastAsyncRequestFinetuneLoss.Mse,
                "poisson" => ForecastAsyncRequestFinetuneLoss.Poisson,
                "rmse" => ForecastAsyncRequestFinetuneLoss.Rmse,
                "smape" => ForecastAsyncRequestFinetuneLoss.Smape,
                _ => null,
            };
        }
    }
}