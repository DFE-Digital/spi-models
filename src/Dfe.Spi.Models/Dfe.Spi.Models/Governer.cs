﻿namespace Dfe.Spi.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// A governer.
    /// </summary>
    public class Governer : ModelsBase
    {
        /// <summary>
        /// Gets or sets a set of <see cref="LearningProvider" /> instances.
        /// </summary>
        public IEnumerable<LearningProvider> LearningProviders
        {
            get;
            set;
        }
    }
}