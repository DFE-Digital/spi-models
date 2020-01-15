namespace Dfe.Spi.Models
{
    using Meridian.MeaningfulToString;

    /// <summary>
    /// Abstract base class for all models in the library.
    /// </summary>
    public abstract class ModelsBase : MeaningfulBase
    {
        /// <summary>
        /// Gets or sets the name of the entity.
        /// </summary>
        public string Name
        {
            get;
            set;
        }
    }
}