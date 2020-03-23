namespace Dfe.Spi.Models.Entities
{
    using Dfe.Spi.Models.RatesModels;

    /// <summary>
    /// Contains information about rates.
    /// </summary>
    public class Rates : EntityBase
    {
        /// <summary>
        /// Gets or sets an instance of
        /// <see cref="RatesModels.BaselineFunding" />.
        /// </summary>
        public BaselineFunding BaselineFunding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets an instance of
        /// <see cref="RatesModels.IllustrativeFunding" />.
        /// </summary>
        public IllustrativeFunding IllustrativeFunding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets an instanace of
        /// <see cref="RatesModels.NotionalFunding" />.
        /// </summary>
        public NotionalFunding NotionalFunding
        {
            get;
            set;
        }
    }
}