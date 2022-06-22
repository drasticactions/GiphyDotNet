// <copyright file="Data.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace GiphyDotNet.Model.GiphyRandomImage
{
    public class Data
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("image_original_url")]
        public string? ImageOriginalUrl { get; set; }

        [JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        [JsonPropertyName("image_mp4_url")]
        public string? ImageMp4Url { get; set; }

        [JsonPropertyName("image_frames")]
        public string? ImageFrames { get; set; }

        [JsonPropertyName("image_width")]
        public string? ImageWidth { get; set; }

        [JsonPropertyName("image_height")]
        public string? ImageHeight { get; set; }

        [JsonPropertyName("fixed_height_downsampled_url")]
        public string? FixedHeightDownsampledUrl { get; set; }

        [JsonPropertyName("fixed_height_downsampled_width")]
        public string? FixedHeightDownsampledWidth { get; set; }

        [JsonPropertyName("fixed_height_downsampled_height")]
        public string? FixedHeightDownsampledHeight { get; set; }

        [JsonPropertyName("fixed_width_downsampled_url")]
        public string? FixedWidthDownsampledUrl { get; set; }

        [JsonPropertyName("fixed_width_downsampled_width")]
        public string? FixedWidthDownsampledWidth { get; set; }

        [JsonPropertyName("fixed_width_downsampled_height")]
        public string? FixedWidthDownsampledHeight { get; set; }

        [JsonPropertyName("fixed_height_small_url")]
        public string? FixedHeightSmallUrl { get; set; }

        [JsonPropertyName("fixed_height_small_still_url")]
        public string? FixedHeightSmallStillUrl { get; set; }

        [JsonPropertyName("fixed_height_small_width")]
        public string? FixedHeightSmallWidth { get; set; }

        [JsonPropertyName("fixed_height_small_height")]
        public string? FixedHeightSmallHeight { get; set; }

        [JsonPropertyName("fixed_width_small_url")]
        public string? FixedWidthSmallUrl { get; set; }

        [JsonPropertyName("fixed_width_small_still_url")]
        public string? FixedWidthSmallStillUrl { get; set; }

        [JsonPropertyName("fixed_width_small_width")]
        public string? FixedWidthSmallWidth { get; set; }

        [JsonPropertyName("fixed_width_small_height")]
        public string? FixedWidthSmallHeight { get; set; }
    }
}
