namespace Dfe.Spi.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a lineage entry.
    /// </summary>
    public class LineageEntry : ModelsBase
    {
        /// <summary>
        /// Gets or sets the adapter from which the entry was read.
        /// </summary>
        public string AdapterName { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DateTime" /> the entry was read.
        /// </summary>
        public DateTime? ReadDate { get; set; }

        /// <summary>
        /// Gets or sets an alternative value, if applicable.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets alternative values, if applicable.
        /// </summary>
        public IEnumerable<LineageEntry> Alternatives { get; set; }
    }
}