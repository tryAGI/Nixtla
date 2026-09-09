
#nullable enable

namespace Nixtla
{
    /// <summary>
    /// The loss used to train the large time model on the data. Select from ['default', 'mae', 'mse', 'rmse', 'mape', 'smape', 'poisson']. It will only be used if finetune_steps is larger than 0. Default is a robust loss function that is less sensitive to outliers.<br/>
    /// Default Value: default
    /// </summary>
    public enum CrossValidationAsyncRequestFinetuneLoss
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
    public static class CrossValidationAsyncRequestFinetuneLossExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CrossValidationAsyncRequestFinetuneLoss value)
        {
            return value switch
            {
                CrossValidationAsyncRequestFinetuneLoss.Default => "default",
                CrossValidationAsyncRequestFinetuneLoss.Mae => "mae",
                CrossValidationAsyncRequestFinetuneLoss.Mape => "mape",
                CrossValidationAsyncRequestFinetuneLoss.Mse => "mse",
                CrossValidationAsyncRequestFinetuneLoss.Poisson => "poisson",
                CrossValidationAsyncRequestFinetuneLoss.Rmse => "rmse",
                CrossValidationAsyncRequestFinetuneLoss.Smape => "smape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CrossValidationAsyncRequestFinetuneLoss? ToEnum(string value)
        {
            return value switch
            {
                "default" => CrossValidationAsyncRequestFinetuneLoss.Default,
                "mae" => CrossValidationAsyncRequestFinetuneLoss.Mae,
                "mape" => CrossValidationAsyncRequestFinetuneLoss.Mape,
                "mse" => CrossValidationAsyncRequestFinetuneLoss.Mse,
                "poisson" => CrossValidationAsyncRequestFinetuneLoss.Poisson,
                "rmse" => CrossValidationAsyncRequestFinetuneLoss.Rmse,
                "smape" => CrossValidationAsyncRequestFinetuneLoss.Smape,
                _ => null,
            };
        }
    }
}