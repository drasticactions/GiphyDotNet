using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiphyDotNet.Model.Parameters
{
    public class TranslateParameter
    {
        /// <summary>
        /// term or phrase to translate into a GIF
        /// </summary>
        public string Phrase { get; set; }

        /// <summary>
        /// limit results to those rated (y,g, pg, pg-13 or r).
        /// </summary>
        public Rating Rating { get; set; }

        /// <summary>
        /// (optional) return results in html or json format (useful for viewing responses as GIFs to debug/test)
        /// </summary>
        public string Format { get; set; }
    }
}
