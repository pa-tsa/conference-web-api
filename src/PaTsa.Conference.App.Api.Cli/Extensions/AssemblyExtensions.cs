using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Reflection;

namespace PaTsa.Conference.App.Api.Cli.Extensions;

public static class AssemblyExtensions
{
    internal static IEnumerable<Type> GetAllDescendantsOfCommandBase(this Assembly assembly)
    {
        return assembly
                   .GetTypes()
                   .Where(_ =>
                       !_.IsAbstract &&
                       _.IsClass &&
                       _.IsAssignableTo(typeof(Command)))
               ?? throw new ArgumentNullException(nameof(assembly));
    }
}
