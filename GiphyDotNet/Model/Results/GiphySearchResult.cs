// <copyright file="GiphySearchResult.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;
using GiphyDotNet.Model.GiphyImage;

namespace GiphyDotNet.Model.Results
{
    public class GiphySearchResult
    {
        [JsonPropertyName("data")]
        public Data[]? Data { get; set; }

        [JsonPropertyName("meta")]
        public Meta? Meta { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination? Pagination { get; set; }
    }
}
