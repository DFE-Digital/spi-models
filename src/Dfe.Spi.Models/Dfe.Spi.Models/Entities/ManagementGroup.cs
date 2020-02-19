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
    }
}