namespace Dfe.Spi.Models
{
    /// <summary>
    /// An address.
    /// </summary>
    public class Address : ModelsBase
    {
        /// <summary>
        /// Gets or sets the first address line.
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the second address line.
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the third address line.
        /// </summary>
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Gets or sets the town.
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        public string County { get; set; }
    }
}