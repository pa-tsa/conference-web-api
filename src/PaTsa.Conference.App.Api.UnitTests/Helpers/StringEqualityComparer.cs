using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace PaTsa.Conference.App.Api.UnitTests.Helpers;

[ExcludeFromCodeCoverage]
internal class StringEqualityComparer : IEqualityComparer<string?>
{
    public bool Equals(string? x, string? y)
    {
        return string.Equals(x, y, StringComparison.InvariantCultureIgnoreCase);
    }

    public int GetHashCode(string? obj)
    {
        return obj == null ? 0 : obj.GetHashCode(StringComparison.InvariantCultureIgnoreCase);
    }
}
