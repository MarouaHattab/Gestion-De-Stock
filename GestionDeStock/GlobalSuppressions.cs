// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

// Suppress warnings about nullability in event handlers since these come from the .NET Framework
// and we don't need to worry about them in our code.
[assembly: SuppressMessage("Nullability", "CS8622:Nullability of reference types in type of parameter doesn't match the target delegate", Justification = "Event handlers use object instead of object? by convention")] 