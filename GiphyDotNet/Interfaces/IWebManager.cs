// <copyright file="IWebManager.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using GiphyDotNet.Model.Web;

namespace GiphyDotNet.Interfaces
{
    /// <summary>
    /// Giphy Web Manager.
    /// </summary>
    internal interface IWebManager
    {
        /// <summary>
        /// Get data from Giphy.
        /// </summary>
        /// <param name="uri">Giphy Uri.</param>
        /// <returns><see cref="Result"/>.</returns>
        Task<Result> GetData(Uri uri);
    }
}
