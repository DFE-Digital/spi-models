namespace Dfe.Spi.Models.Entities
{
    /// <summary>
    /// Base class for which all top-level entities to derive from.
    /// </summary>
    public abstract class EntityBase : ModelsBase
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