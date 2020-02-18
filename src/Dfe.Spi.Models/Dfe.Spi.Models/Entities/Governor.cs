namespace Dfe.Spi.Models.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// A governer.
    /// </summary>
    public class Governor : EntityBase
    {
        /// <summary>
        /// Gets or sets a set of <see cref="LearningProvider" /> instances.
        /// </summary>
        public IEnumerable<LearningProvider> LearningProviders
        {
            get;
            set;
        }
    }
}