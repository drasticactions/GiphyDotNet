using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiphyDotNet.Model.GiphyImage;
using System.Text.Json.Serialization;

namespace GiphyDotNet.Model.Results
{
    public class GiphySearchResult
    {
        [JsonPropertyName("data")]
        public Data[] Data { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }
}
