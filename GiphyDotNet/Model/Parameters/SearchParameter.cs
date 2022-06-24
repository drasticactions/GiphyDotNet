// <copyright file="SearchParameter.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace GiphyDotNet.Model.Parameters
{
    /// <summary>
    /// Search Parameter.
    /// </summary>
    public class SearchParameter
    {
        /// <summary>
        /// Gets or sets the GifSearch query term or phrase.
        /// </summary>
        public string? Query { get; set; }

        /// <summary>
        /// Gets or sets the limit. (optional) number of results to return, maximum 100. Default 25.
        /// </summary>
        public int Limit { get; set; } = 25;

        /// <summary>
        /// Gets or sets the offset. (optional) results offset, defaults to 0.
        /// </summary>
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Gets or sets the rating: limit results to those rated (y,g, pg, pg-13 or r).
        /// </summary>
        public Rating Rating { get; set; }

        /// <summary>
        /// Gets or sets the format: (optional) return results in html or json format (useful for viewing responses as GIFs to debug/test).
        /// </summary>
        public string? Format { get; set; }

        /// <summary>
        /// Gets or sets the language for the query.
        /// Specify default language for regional content; use a 2-letter ISO 639-1 language code.
        /// Defaults to en.
        /// See https://developers.giphy.com/docs/optional-settings/#language-support for supported language codes.
        /// </summary>
        public string? Language { get; set; } = "en";
    }
}
