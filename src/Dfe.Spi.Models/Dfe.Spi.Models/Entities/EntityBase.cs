namespace Dfe.Spi.Models.Entities
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using Newtonsoft.Json;

    /// <summary>
    /// Base class for which all top-level entities to derive from.
    /// </summary>
    public abstract class EntityBase : ModelsBase
    {
        /// <summary>
        /// Gets or sets the lineage for the entity.
        /// </summary>
        [SuppressMessage(
            "Microsoft.Usage",
            "CA2227",
            Justification = "This is a DTO.")]
        [SuppressMessage(
            "Naming Rules",
            "SA1300",
            Justification = "This is a special case/property, stylised as such for (de)serialisation purposes.")]
        [SuppressMessage(
            "Microsoft.Naming",
            "CA1707",
            Justification = "This is a special case/property, stylised as such for (de)serialisation purposes.")]
        [JsonProperty("_lineage", Order = -2)]
        public Dictionary<string, LineageEntry> _Lineage { get; set; }

        /// <summary>
        /// Gets or sets the name of the entity.
        /// </summary>
        public string Name { get; set; }
    }
}