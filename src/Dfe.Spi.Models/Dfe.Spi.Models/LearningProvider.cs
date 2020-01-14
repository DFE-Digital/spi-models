namespace Dfe.Spi.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// A learning provider.
    /// </summary>
    public class LearningProvider : ModelsBase
    {
        /// <summary>
        /// Gets or sets a set of <see cref="Governor" /> instances.
        /// </summary>
        public IEnumerable<Governor> Governors
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the legal name of the entity.
        /// </summary>
        public string LegalName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the URN of the entity.
        /// </summary>
        public long Urn
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UKPRN of the entity.
        /// </summary>
        public long Ukprn
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Postcode of the entity.
        /// </summary>
        public long Postcode
        {
            get;
            set;
        }
    }
}