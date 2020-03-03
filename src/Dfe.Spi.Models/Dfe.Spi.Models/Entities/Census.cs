using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace Dfe.Spi.Models.Entities
{
    /// <summary>
    /// A Census
    /// </summary>
    public class Census : EntityBase
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
        [JsonProperty("_aggregations", Order = -1)]
        public Aggregation[] _Aggregations { get; set; }
    }
}