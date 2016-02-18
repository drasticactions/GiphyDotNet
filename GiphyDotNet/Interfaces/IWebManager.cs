using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GiphyDotNet.Model.Web;

namespace GiphyDotNet.Interfaces
{
    internal interface IWebManager
    {
        Task<Result> GetData(Uri uri);
    }
}
