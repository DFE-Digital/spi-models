namespace Dfe.Spi.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A learning provider.
    /// </summary>
    public class LearningProvider : ModelsBase
    {
        /// <summary>
        /// Gets or sets a set of <see cref="Governor" /> instances.
        /// </summary>
        public IEnumerable<Governor> Governors { get; set; }

        /// <summary>
        /// Gets or sets the legal name of the entity.
        /// </summary>
        public string LegalName { get; set; }

        /// <summary>
        /// Gets or sets the URN of the entity.
        /// </summary>
        public long? Urn { get; set; }

        /// <summary>
        /// Gets or sets the UKPRN of the entity.
        /// </summary>
        public long? Ukprn { get; set; }

        /// <summary>
        /// Gets or sets the Postcode of the entity.
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// Gets or sets the Status of the entity.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the Type of the entity.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the SubType of the entity.
        /// </summary>
        public string SubType { get; set; }

        /// <summary>
        /// Gets or sets the OpenDate of the entity.
        /// </summary>
        public DateTime OpenDate { get; set; }

        /// <summary>
        /// Gets or sets the CloseDate of the entity.
        /// </summary>
        public DateTime CloseDate { get; set; }
    }
}