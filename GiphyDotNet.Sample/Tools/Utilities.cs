// <copyright file="Utilities.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Reflection;

namespace GiphyDotNet.Sample
{
    public static class Utilities
    {
        public static byte[] GetPlaceholderIcon()
        {
            var resource = GetResourceFileContent("Icon.favicon.ico");
            if (resource is null)
            {
                throw new Exception("Failed to get placeholder icon.");
            }

            using MemoryStream ms = new MemoryStream();
            resource.CopyTo(ms);
            return ms.ToArray();
        }

        /// <summary>
        /// Get Resource File Content via FileName.
        /// </summary>
        /// <param name="fileName">Filename.</param>
        /// <returns>Stream.</returns>
        public static Stream? GetResourceFileContent(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "DotnetRss.Core." + fileName;
            if (assembly is null)
            {
                return null;
            }

            return assembly.GetManifestResourceStream(resourceName);
        }
    }
}
