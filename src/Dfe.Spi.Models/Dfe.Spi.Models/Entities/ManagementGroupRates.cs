namespace Dfe.Spi.Models.Entities
{
    using Dfe.Spi.Models.RatesModels.ManagementGroupModels;

    /// <summary>
    /// Contains information about rates for management groups in particular.
    /// </summary>
    public class ManagementGroupRates : EntityBase
    {
        /// <summary>
        /// Gets or sets a
        /// <see cref="RatesModels.ManagementGroupModels.ProvisionalFunding" />
        /// instance.
        /// </summary>
        public ProvisionalFunding ProvisionalFunding
        {
            get;
            set;
        }
    }
}