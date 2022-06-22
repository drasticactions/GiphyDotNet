// <copyright file="GiphyIdResult.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;
using GiphyDotNet.Model.GiphyImage;

namespace GiphyDotNet.Model.Results
{
    /// <summary>
    /// Giphy Id Result.
    /// </summary>
    public class GiphyIdResult
    {
        [JsonPropertyName("data")]
        public Data? Data { get; set; }

        [JsonPropertyName("meta")]
        public Meta? Meta { get; set; }
    }
}
