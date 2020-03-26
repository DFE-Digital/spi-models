namespace Dfe.Spi.Models.Entities
{
    using Dfe.Spi.Models.RatesModels.LearningProviderModels;

    /// <summary>
    /// Contains information about rates for learning providers in particular.
    /// </summary>
    public class LearningProviderRates : EntityBase
    {
        /// <summary>
        /// Gets or sets an instance of
        /// <see cref="RatesModels.LearningProviderModels.BaselineFunding" />.
        /// </summary>
        public BaselineFunding BaselineFunding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets an instance of
        /// <see cref="RatesModels.LearningProviderModels.IllustrativeFunding" />.
        /// </summary>
        public IllustrativeFunding IllustrativeFunding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets an instanace of
        /// <see cref="RatesModels.LearningProviderModels.NotionalFunding" />.
        /// </summary>
        public NotionalFunding NotionalFunding
        {
            get;
            set;
        }
    }
}