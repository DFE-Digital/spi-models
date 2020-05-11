namespace Dfe.Spi.Models.Entities
{
    /// <summary>
    /// A management group (Such as SAT, MAT of LA).
    /// </summary>
    public class ManagementGroup : EntityBase
    {
        /// <summary>
        /// Gets or sets the type of management group.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the unique reference of the management group.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the management group (Such as UID for SAT or LA Code for LA).
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the Companies House number of the entity.
        /// </summary>
        public string CompaniesHouseNumber { get; set; }

        /// <summary>
        /// Gets or sets the UKPRN of the entity.
        /// </summary>
        public long? Ukprn { get; set; }

        /// <summary>
        /// Gets or sets the first address line.
        /// Example: "Anstey Lane".
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the second address line.
        /// Example: "Thurcaston".
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the third address line.
        /// Example: NULL.
        /// </summary>
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Gets or sets the town.
        /// Example: "Leicester".
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// Example: NULL, "Leicestershire".
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Gets or sets the Postcode of the entity.
        /// Example: "LE12 8DX".
        /// </summary>
        public string Postcode { get; set; }
    }
}