using System.Threading.Tasks;

namespace PaTsa.Conference.App.Api.Cli.Handlers;

public interface ICommandHandler<in TArgs> where TArgs : class
{
    Task Handle(TArgs args);
}
