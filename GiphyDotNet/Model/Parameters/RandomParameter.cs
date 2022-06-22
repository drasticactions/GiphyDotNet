// <copyright file="RandomParameter.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace GiphyDotNet.Model.Parameters
{
    /// <summary>
    /// Random API Parameter.
    /// </summary>
    public class RandomParameter
    {
        /// <summary>
        /// Gets or sets the GIF tag to limit randomness by.
        /// </summary>
        public string? Tag { get; set; }

        /// <summary>
        /// Gets or sets thr rating: limit results to those rated (y,g, pg, pg-13 or r).
        /// </summary>
        public Rating Rating { get; set; }

        /// <summary>
        /// Gets or sets the format. (optional) return results in html or json format (useful for viewing responses as GIFs to debug/test).
        /// </summary>
        public string? Format { get; set; }
    }
}
