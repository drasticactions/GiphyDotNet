// <copyright file="GiphyIdsResult.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;
using GiphyDotNet.Model.GiphyImage;

namespace GiphyDotNet.Model.Results
{
    public class GiphyIdsResult
    {
        [JsonPropertyName("data")]
        public Data[]? Data { get; set; }

        [JsonPropertyName("meta")]
        public Meta? Meta { get; set; }
    }
}
