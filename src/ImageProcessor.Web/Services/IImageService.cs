﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IImageService.cs" company="James South">
//   Copyright (c) James South.
//   Licensed under the Apache License, Version 2.0.
// </copyright>
// <summary>
//   Defines properties and methods for allowing retrieval of image from different sources.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ImageProcessor.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    ///  Defines properties and methods for allowing retrieval of image from different sources.
    /// </summary>
    public interface IImageService
    {
        /// <summary>
        /// Gets the key for the given implementation.
        /// <remarks>
        /// This value is used as a prefix for any image requests that should use this service.
        /// </remarks>
        /// </summary>
        string Key { get; }

        /// <summary>
        /// Gets a value indicating whether the image service requests files from
        /// the locally based file system.
        /// </summary>
        bool IsFileLocalService { get; }

        /// <summary>
        /// Gets or sets any additional settings required by the service.
        /// </summary>
        Dictionary<string, string> Settings { get; set; }

        /// <summary>
        /// Gets or sets the white list of <see cref="System.Uri"/>. 
        /// </summary>
        Uri[] WhiteList { get; set; }

        /// <summary>
        /// Gets the image using the given identifier.
        /// </summary>
        /// <param name="id">
        /// The value identifying the image to fetch.
        /// </param>
        /// <returns>
        /// The <see cref="System.Byte"/> array containing the image data.
        /// </returns>
        Task<byte[]> GetImage(object id);
    }
}