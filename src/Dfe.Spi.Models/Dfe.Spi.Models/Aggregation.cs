namespace Dfe.Spi.Models
{
    /// <summary>
    /// The result of an aggregation.
    /// </summary>
    public class Aggregation : ModelsBase
    {
        /// <summary>
        /// Gets or sets the name of the aggregation.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the outcome of the aggregation.
        /// </summary>
        public decimal Value { get; set; }
    }
}