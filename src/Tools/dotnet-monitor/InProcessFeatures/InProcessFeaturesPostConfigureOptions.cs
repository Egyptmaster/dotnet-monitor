﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Diagnostics.Monitoring.Options;
using Microsoft.Extensions.Options;

namespace Microsoft.Diagnostics.Tools.Monitor
{
    internal sealed class InProcessFeaturesPostConfigureOptions :
        IPostConfigureOptions<InProcessFeaturesOptions>
    {
        public void PostConfigure(string name, InProcessFeaturesOptions options)
        {
            // Stacks is currently the only in-process feature; if this feature is not
            // enabled, disable all in-process feature support.
            if (!ExperimentalFlags.IsCallStacksEnabled)
            {
                options.Enabled = false;
            }
        }
    }
}
