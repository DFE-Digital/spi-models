namespace Dfe.Spi.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// A learning provider.
    /// </summary>
    public class LearningProvider : ModelsBase
    {
        /// <summary>
        /// Gets or sets a set of <see cref="Governer" /> instances.
        /// </summary>
        public IEnumerable<Governer> Governers
        {
            get;
            set;
        }
    }
}