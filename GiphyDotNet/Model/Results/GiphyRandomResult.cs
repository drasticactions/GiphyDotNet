using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GiphyDotNet.Model.GiphyImage;

namespace GiphyDotNet.Model.Results
{
    public class GiphyRandomResult
    {
        [JsonPropertyName("data")]
        public GiphyRandomImage.Data Data { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
}
