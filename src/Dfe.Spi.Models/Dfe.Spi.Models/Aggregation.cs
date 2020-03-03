namespace Dfe.Spi.Models
{
    /// <summary>
    /// The result of an aggregation
    /// </summary>
    public class Aggregation : ModelsBase
    {
        /// <summary>
        /// The name of the aggregation
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// The outcome of the aggregation
        /// </summary>
        public decimal Value { get; set; }
    }
}