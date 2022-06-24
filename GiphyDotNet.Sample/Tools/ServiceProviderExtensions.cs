// <copyright file="ServiceProviderExtensions.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using Microsoft.Extensions.DependencyInjection;

namespace GiphyDotNet.Sample.Tools
{
    /// <summary>
    /// Service Provider Extensions.
    /// </summary>
    public static class ServiceProviderExtensions
    {
        /// <summary>
        /// Resolve With.
        /// </summary>
        /// <typeparam name="T">T.</typeparam>
        /// <param name="provider">Provider.</param>
        /// <param name="parameters">Parameters.</param>
        /// <returns>T Value.</returns>
        public static T ResolveWith<T>(this IServiceProvider provider, params object[] parameters)
            where T : class =>
            ActivatorUtilities.CreateInstance<T>(provider, parameters);
    }
}
