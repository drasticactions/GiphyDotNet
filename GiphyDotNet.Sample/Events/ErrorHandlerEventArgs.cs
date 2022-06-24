// <copyright file="ErrorHandlerEventArgs.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace GiphyDotNet.Sample
{
    /// <summary>
    /// Error Handler Event Args.
    /// </summary>
    public class ErrorHandlerEventArgs : EventArgs
    {
        private readonly Exception exception;

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorHandlerEventArgs"/> class.
        /// </summary>
        /// <param name="ex">Exception.</param>
        public ErrorHandlerEventArgs(Exception ex)
        {
            this.exception = ex;
        }

        /// <summary>
        /// Gets the Exception.
        /// </summary>
        public Exception Exception => this.exception;
    }
}
