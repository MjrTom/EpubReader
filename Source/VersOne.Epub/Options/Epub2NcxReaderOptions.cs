﻿using System.Diagnostics.CodeAnalysis;

namespace VersOne.Epub.Options
{
    /// <summary>
    /// Various options to configure the behavior of the EPUB 2 NCX navigation document reader.
    /// </summary>
    public class Epub2NcxReaderOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Epub2NcxReaderOptions" /> class.
        /// </summary>
        /// <param name="preset">An optional preset to initialize the <see cref="Epub2NcxReaderOptions" /> class with a predefined set of options.</param>
        [SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Temporarily ignore unused 'preset' parameter.")]
        public Epub2NcxReaderOptions(EpubReaderOptionsPreset? preset = null)
        {
            IgnoreMissingContentForNavigationPoints = false;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the EPUB 2 NCX reader should ignore missing content attribute on the navigation points in the NCX.
        /// If it's set to <c>false</c> and the content attribute is not present, then the "navigation point X should contain at least one navigation label" exception will be thrown.
        /// Otherwise all navigation points without the content attribute and all their child navigation points will be excluded from the navigation map.
        /// Default value is <c>false</c>.
        /// </summary>
        public bool IgnoreMissingContentForNavigationPoints { get; set; }
    }
}
