using System.Collections.Generic;

namespace PaTsa.Conference.App.Api.Cli.Extensions;

public static class ListExtensions
{
    internal static void AddIfDoesNotExist<T>(this IList<T> list, T obj)
    {
        if (!list.Contains(obj)) list.Add(obj);
    }
}
