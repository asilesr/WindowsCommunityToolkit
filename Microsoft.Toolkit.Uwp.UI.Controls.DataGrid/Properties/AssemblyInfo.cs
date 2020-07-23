// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Resources;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
#if WINDOWS_UWP
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("UnitTests.UWP")]
#endif
[assembly: NeutralResourcesLanguage("en-US")]