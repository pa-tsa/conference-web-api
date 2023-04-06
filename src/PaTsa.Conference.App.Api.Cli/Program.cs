using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using PaTsa.Conference.App.Api.Cli.Commands;

namespace PaTsa.Conference.App.Api.Cli;

public class Program
{
    public static async Task Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection
            .AddSingleton<EnvironmentVariableProvider>();

        var serviceProvider = serviceCollection.BuildServiceProvider();

        var root = new RootCommand("CLI for PA TSA Conference App API.")
            .AddCommands(serviceProvider);

        var commandLineBuilder = new CommandLineBuilder(root);

        var parser = commandLineBuilder
            .UseDefaults()
            .Build();

        await parser.InvokeAsync(args);
    }
}
