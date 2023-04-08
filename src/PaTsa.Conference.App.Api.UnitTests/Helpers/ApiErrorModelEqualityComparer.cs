using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using PaTsa.Conference.App.Api.WebApi.Models;

namespace PaTsa.Conference.App.Api.UnitTests.Helpers;

[ExcludeFromCodeCoverage]
public class ApiErrorModelEqualityComparer : IEqualityComparer<ApiErrorModel>
{
    public bool Equals(ApiErrorModel? x, ApiErrorModel? y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (x is null) return false;
        if (y is null) return false;

        var errorCodesMatch = x.ErrorCode == y.ErrorCode;
        var messagesMatch = x.Message == y.Message;

        return errorCodesMatch && messagesMatch;
    }

    public int GetHashCode(ApiErrorModel obj)
    {
        return HashCode.Combine(obj.ErrorCode, obj.Message);
    }
}
