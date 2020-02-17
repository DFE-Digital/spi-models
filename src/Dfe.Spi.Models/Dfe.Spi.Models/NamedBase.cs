namespace Dfe.Spi.Models
{
    /// <summary>
    /// A named entity.
    /// </summary>
    public abstract class NamedBase : ModelsBase
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