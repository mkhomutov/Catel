﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SuspensionModeExtensions.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Catel.Collections.Extensions
{
    using System.Collections.Generic;

    /// <summary>
    /// The suspension mode extensions.
    /// </summary>
    internal static class SuspensionModeExtensions
    {
        #region Fields
        /// <summary>
        /// The mixed modes.
        /// </summary>
        private static readonly List<SuspensionMode> MixedModes;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// Initializes static members of the <see cref="SuspensionModeExtensions"/> class.
        /// </summary>
        static SuspensionModeExtensions()
        {
            MixedModes = new List<SuspensionMode>
                              {
                                  SuspensionMode.Mixed,
                                  SuspensionMode.MixedBash
                              };
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// The is mixed mode.
        /// </summary>
        /// <param name="suspensionMode">The suspension Mode.</param>
        /// <returns><c>True</c> if <see cref="SuspensionMode"/> is one of the mixed modes; otherwise, <c>false</c>.</returns>
        public static bool IsMixedMode(this SuspensionMode suspensionMode)
        {
            return MixedModes.Contains(suspensionMode);
        }
        #endregion Methods
    }
}