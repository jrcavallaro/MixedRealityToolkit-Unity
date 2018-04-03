﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace MixedRealityToolkit.Internal.Definitions
{
    /// <summary>
    /// The ControllerInputType identifies the type of button or input being sent to the framework from a controller.
    /// This is mainly information only or for advanced users to understand the input coming directly from the controller.
    /// </summary>
    public enum ControllerInputType
    {
        /// <summary>
        /// No Specified type.
        /// </summary>
        None = 0,
        /// <summary>
        /// Digital On/Off input.
        /// </summary>
        Digital,
        /// <summary>
        /// Single Axis analogue input.
        /// </summary>
        SingleAxis,
        /// <summary>
        /// Dual Axis analogue input.
        /// </summary>
        DualAxis,
        /// <summary>
        /// Dual Axis analogue input.
        /// </summary>
        ThreeDoF,
        /// <summary>
        /// Position AND Rotation analogue input.
        /// </summary>
        SixDoF,
        /// <summary>
        /// Raw stream from input (proxy only).
        /// </summary>
        Raw,
    }
}