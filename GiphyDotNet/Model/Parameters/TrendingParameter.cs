// <copyright file="TrendingParameter.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace GiphyDotNet.Model.Parameters
{
    public class TrendingParameter
    {
        /// <summary>
        /// (optional) number of results to return, maximum 100. Default 25.
        /// </summary>
        public int Limit { get; set; } = 25;

        /// <summary>
        /// limit results to those rated (y,g, pg, pg-13 or r).
        /// </summary>
        public Rating Rating { get; set; }

        /// <summary>
        /// (optional) return results in html or json format (useful for viewing responses as GIFs to debug/test)
        /// </summary>
        public string? Format { get; set; }
    }
}
