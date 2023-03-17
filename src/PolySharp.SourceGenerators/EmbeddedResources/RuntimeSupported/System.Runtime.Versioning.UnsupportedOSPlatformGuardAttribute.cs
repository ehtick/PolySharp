// <auto-generated/>
#pragma warning disable
#nullable enable annotations

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Runtime.Versioning
{
    /// <summary>
    /// Annotates the custom guard field, property or method with an unsupported platform name and optional version.
    /// Multiple attributes can be applied to indicate guard for multiple unsupported platforms.
    /// </summary>
    /// <remarks>
    /// Callers can apply a <see cref="global::System.Runtime.Versioning.UnsupportedOSPlatformGuardAttribute " /> to a field, property or method
    /// and use that  field, property or method in a conditional or assert statements as a guard to safely call APIs unsupported on those platforms.
    ///
    /// The type of the field or property should be boolean, the method return type should be boolean in order to be used as platform guard.
    /// </remarks>
    [global::System.AttributeUsage(
        global::System.AttributeTargets.Field |
        global::System.AttributeTargets.Method |
        global::System.AttributeTargets.Property,
        AllowMultiple = true, Inherited = false)]
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.Conditional("MULTI_TARGETING_SUPPORT_ATTRIBUTES")]
    internal sealed class UnsupportedOSPlatformGuardAttribute : global::System.Attribute // OSPlatformAttribute
    {
        public UnsupportedOSPlatformGuardAttribute(string platformName)
            // : base(platformName)
        {
        }
    }
}