// <copyright file="WebManager.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using GiphyDotNet.Interfaces;
using GiphyDotNet.Model.Web;

namespace GiphyDotNet.Manager
{
    /// <summary>
    /// Web Manager.
    /// </summary>
    internal class WebManager : IWebManager
    {
        /// <inheritdoc/>
        public async Task<Result> GetData(Uri uri)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    Result result = new Result(false, string.Empty);
                    var response = await httpClient.GetAsync(uri);
                    var responseContent = await response.Content.ReadAsStringAsync();
                    result.IsSuccess = response.IsSuccessStatusCode;
                    result.ResultJson = responseContent;
                    return result;
                }
                catch (Exception ex)
                {
                    return new Result(false, ex.Message);
                }
            }
        }
    }
}
