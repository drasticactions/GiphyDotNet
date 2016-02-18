using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiphyDotNet.Model.GiphyImage;
using Newtonsoft.Json;

namespace GiphyDotNet.Model.Results
{
    public class GiphySearchResult
    {
        [JsonProperty("data")]
        public Data[] Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }
}
