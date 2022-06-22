// <copyright file="Meta.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace GiphyDotNet.Model.GiphyImage
{
    public class Meta
    {
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        [JsonPropertyName("msg")]
        public string? Msg { get; set; }
    }
}
