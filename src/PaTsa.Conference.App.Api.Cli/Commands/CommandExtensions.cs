using System;
using System.CommandLine;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using PaTsa.Conference.App.Api.Cli.Extensions;
using PaTsa.Conference.App.Api.Cli.Handlers;

namespace PaTsa.Conference.App.Api.Cli.Commands;

public static class CommandExtensions
{
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static RootCommand AddCommands(this RootCommand rootCommand, ServiceProvider serviceProvider)
    {
        if (rootCommand is null)
        {
            throw new ArgumentNullException(nameof(rootCommand));
        }

        foreach (var commandType in Assembly.GetCallingAssembly().GetAllDescendantsOfCommandBase())
        {
            if (commandType.BaseType == null) continue;

            var commandBaseType = commandType.BaseType.IsGenericType && commandType.BaseType.GetGenericTypeDefinition() == typeof(CommandBase<,>)
                ? commandType.BaseType
                : commandType.BaseType.BaseType;

            if (commandBaseType == null) throw new NullReferenceException($"The `{nameof(commandBaseType)}` cannot be null");

            var argumentsType = commandBaseType.GetGenericArguments()[0];
            var handlerType = commandBaseType.GetGenericArguments()[1];

            var commandExtensionType = typeof(CommandExtensions);

            var configureCommandMethodInfo = commandExtensionType
                .GetMethod(nameof(ConfigureCommand), BindingFlags.NonPublic | BindingFlags.Static);

            if (configureCommandMethodInfo == null) throw new NullReferenceException($"The {nameof(ConfigureCommand)} method info cannot be null");

            var genericConfigureMethodInfo = configureCommandMethodInfo
                .MakeGenericMethod(commandType, argumentsType, handlerType);

            if (genericConfigureMethodInfo.Invoke(null, new object[] { serviceProvider }) is not Command command)
            {
                throw new NullReferenceException("The invoked command cannot be null");
            }

            rootCommand.AddCommand(command);
        }

        return rootCommand;
    }

    [SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "Called via reflection")]
    private static TCommand ConfigureCommand<TCommand, TArgs, THandler>(ServiceProvider serviceProvider) where TArgs : class, new()
        where TCommand : CommandBase<TArgs, THandler>, new()
        where THandler : ICommandHandler<TArgs>
    {
        var command = new TCommand();
        var argsBinder = new GenericArgumentsBinder<TCommand, TArgs>(command);

        command.SetHandler(async arguments => await command.BuildHandler(arguments, serviceProvider).Handle(arguments), argsBinder);

        return command;
    }
}
