// <copyright file="MauiAppDispatcher.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace GiphyDotNet.Sample
{
    public class MauiAppDispatcher : IAppDispatcher
    {
        /// <inheritdoc/>
        public bool Dispatch(Action action)
        {
            return App.Current?.Dispatcher.Dispatch(action) ?? false;
        }
    }
}
