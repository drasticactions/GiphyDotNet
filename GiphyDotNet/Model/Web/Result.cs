// <copyright file="Result.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace GiphyDotNet.Model.Web
{
    /// <summary>
    /// Web Result.
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Result"/> class.
        /// </summary>
        /// <param name="isSuccess">Is Success.</param>
        /// <param name="json">The result JSON.</param>
        public Result(bool isSuccess = false, string json = "")
        {
            this.IsSuccess = isSuccess;
            this.ResultJson = json;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the result was successful.
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Gets or sets the result JSON.
        /// </summary>
        public string ResultJson { get; set; }

        /// <summary>
        /// Gets or sets the error JSON.
        /// </summary>
        public string? Error { get; set; }
    }
}
