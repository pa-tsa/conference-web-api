using System.Threading;
using System.Threading.Tasks;

namespace PaTsa.Conference.App.Api.WebApi.Services;

public interface IPingableService
{
    string ServiceName { get; }

    Task<bool> PingAsync(CancellationToken cancellationToken = default);
}
