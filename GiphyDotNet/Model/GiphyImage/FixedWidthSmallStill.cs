// <copyright file="FixedWidthSmallStill.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace GiphyDotNet.Model.GiphyImage
{
    public class FixedWidthSmallStill
    {
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("width")]
        public string? Width { get; set; }

        [JsonPropertyName("height")]
        public string? Height { get; set; }
    }
}
