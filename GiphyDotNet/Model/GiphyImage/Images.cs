﻿// <copyright file="Images.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace GiphyDotNet.Model.GiphyImage
{
    public class Images
    {
        [JsonPropertyName("fixed_height")]
        public FixedHeight? FixedHeight { get; set; }

        [JsonPropertyName("fixed_height_still")]
        public FixedHeightStill? FixedHeightStill { get; set; }

        [JsonPropertyName("fixed_height_downsampled")]
        public FixedHeightDownsampled? FixedHeightDownsampled { get; set; }

        [JsonPropertyName("fixed_width")]
        public FixedWidth? FixedWidth { get; set; }

        [JsonPropertyName("fixed_width_still")]
        public FixedWidthStill? FixedWidthStill { get; set; }

        [JsonPropertyName("fixed_width_downsampled")]
        public FixedWidthDownsampled? FixedWidthDownsampled { get; set; }

        [JsonPropertyName("fixed_height_small")]
        public FixedHeightSmall? FixedHeightSmall { get; set; }

        [JsonPropertyName("fixed_height_small_still")]
        public FixedHeightSmallStill? FixedHeightSmallStill { get; set; }

        [JsonPropertyName("fixed_width_small")]
        public FixedWidthSmall? FixedWidthSmall { get; set; }

        [JsonPropertyName("fixed_width_small_still")]
        public FixedWidthSmallStill? FixedWidthSmallStill { get; set; }

        [JsonPropertyName("downsized")]
        public Downsized? Downsized { get; set; }

        [JsonPropertyName("downsized_still")]
        public DownsizedStill? DownsizedStill { get; set; }

        [JsonPropertyName("downsized_large")]
        public DownsizedLarge? DownsizedLarge { get; set; }

        [JsonPropertyName("original")]
        public Original? Original { get; set; }

        [JsonPropertyName("original_still")]
        public OriginalStill? OriginalStill { get; set; }
    }
}
