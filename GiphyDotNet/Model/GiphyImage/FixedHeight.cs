// <copyright file="FixedHeight.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace GiphyDotNet.Model.GiphyImage
{

    public class FixedHeight
    {
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("width")]
        public string? Width { get; set; }

        [JsonPropertyName("height")]
        public string? Height { get; set; }

        [JsonPropertyName("size")]
        public string? Size { get; set; }

        [JsonPropertyName("mp4")]
        public string? Mp4 { get; set; }

        [JsonPropertyName("mp4_size")]
        public string? Mp4Size { get; set; }

        [JsonPropertyName("webp")]
        public string? Webp { get; set; }

        [JsonPropertyName("webp_size")]
        public string? WebpSize { get; set; }
    }

}
