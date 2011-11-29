﻿using System.Collections.Generic;

namespace Reqoon.Contracts.IO
{
    public interface IFileFormat
    {
        /// <summary>
        /// Gets the name of the parser being implemented. 
        /// This is intended to give the developer name of the parser.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the description of the parser being
        /// implemented. This is intended to give the
        /// developer some information of the parser.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the supported file extensions.
        /// </summary>
        IEnumerable<string> Extensions { get; }
    }
}
