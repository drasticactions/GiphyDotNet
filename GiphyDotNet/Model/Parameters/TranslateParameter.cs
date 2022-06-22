// <copyright file="TranslateParameter.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace GiphyDotNet.Model.Parameters
{
    /// <summary>
    /// Translate Paramter.
    /// </summary>
    public class TranslateParameter
    {
        /// <summary>
        /// Gets or sets the term or phrase to translate into a GIF.
        /// </summary>
        public string? Phrase { get; set; }

        /// <summary>
        /// Gets or sets the limit of results to those rated (y,g, pg, pg-13 or r).
        /// </summary>
        public Rating Rating { get; set; }

        /// <summary>
        /// Gets or sets the format: (optional) return results in html or json format (useful for viewing responses as GIFs to debug/test).
        /// </summary>
        public string? Format { get; set; }
    }
}
