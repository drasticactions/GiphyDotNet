using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiphyDotNet.Model.GiphyImage;
using Newtonsoft.Json;

namespace GiphyDotNet.Model.Results
{
    public class GiphyRandomResult
    {
        [JsonProperty("data")]
        public GiphyRandomImage.Data Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
