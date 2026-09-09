
#nullable enable

namespace Nixtla
{
    /// <summary>
    /// The loss used to train the large time model on the data. Select from ['default', 'mae', 'mse', 'rmse', 'mape', 'smape', 'poisson']. It will only be used if finetune_steps is larger than 0. Default is a robust loss function that is less sensitive to outliers.<br/>
    /// Default Value: default
    /// </summary>
    public enum FinetuneAsyncRequestFinetuneLoss
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
    public static class FinetuneAsyncRequestFinetuneLossExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneAsyncRequestFinetuneLoss value)
        {
            return value switch
            {
                FinetuneAsyncRequestFinetuneLoss.Default => "default",
                FinetuneAsyncRequestFinetuneLoss.Mae => "mae",
                FinetuneAsyncRequestFinetuneLoss.Mape => "mape",
                FinetuneAsyncRequestFinetuneLoss.Mse => "mse",
                FinetuneAsyncRequestFinetuneLoss.Poisson => "poisson",
                FinetuneAsyncRequestFinetuneLoss.Rmse => "rmse",
                FinetuneAsyncRequestFinetuneLoss.Smape => "smape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneAsyncRequestFinetuneLoss? ToEnum(string value)
        {
            return value switch
            {
                "default" => FinetuneAsyncRequestFinetuneLoss.Default,
                "mae" => FinetuneAsyncRequestFinetuneLoss.Mae,
                "mape" => FinetuneAsyncRequestFinetuneLoss.Mape,
                "mse" => FinetuneAsyncRequestFinetuneLoss.Mse,
                "poisson" => FinetuneAsyncRequestFinetuneLoss.Poisson,
                "rmse" => FinetuneAsyncRequestFinetuneLoss.Rmse,
                "smape" => FinetuneAsyncRequestFinetuneLoss.Smape,
                _ => null,
            };
        }
    }
}