using System;
using System.CommandLine;
using PaTsa.Conference.App.Api.Cli.Handlers;

namespace PaTsa.Conference.App.Api.Cli.Commands;

public abstract class CommandBase<TArgs, THandler> : Command where TArgs : class where THandler : ICommandHandler<TArgs>
{
    protected CommandBase(string name, string? description = null) : base(name, description) { }

    public abstract THandler BuildHandler(TArgs arguments, IServiceProvider serviceProvider);
}
