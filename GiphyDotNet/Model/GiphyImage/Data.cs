// <copyright file="Data.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace GiphyDotNet.Model.GiphyImage
{

    public class Data
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("slug")]
        public string? Slug { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("bitly_gif_url")]
        public string? BitlyGifUrl { get; set; }

        [JsonPropertyName("bitly_url")]
        public string? BitlyUrl { get; set; }

        [JsonPropertyName("embed_url")]
        public string? EmbedUrl { get; set; }

        [JsonPropertyName("username")]
        public string? Username { get; set; }

        [JsonPropertyName("source")]
        public string? Source { get; set; }

        [JsonPropertyName("rating")]
        public string? Rating { get; set; }

        [JsonPropertyName("caption")]
        public string? Caption { get; set; }

        [JsonPropertyName("content_url")]
        public string? ContentUrl { get; set; }

        [JsonPropertyName("source_tld")]
        public string? SourceTld { get; set; }

        [JsonPropertyName("source_post_url")]
        public string? SourcePostUrl { get; set; }

        [JsonPropertyName("import_datetime")]
        public string? ImportDatetime { get; set; }

        [JsonPropertyName("trending_datetime")]
        public string? TrendingDatetime { get; set; }

        [JsonPropertyName("images")]
        public Images? Images { get; set; }
    }

}
