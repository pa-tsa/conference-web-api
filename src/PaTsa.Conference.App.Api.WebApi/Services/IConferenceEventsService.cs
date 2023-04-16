using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using PaTsa.Conference.App.Api.WebApi.Entities;

namespace PaTsa.Conference.App.Api.WebApi.Services;

public interface IConferenceEventsService : IMongoEntityService<ConferenceEvent>, IPingableService
{
    Task<List<ConferenceEvent>> FilterAsync(
        IEnumerable<string> eventIds,
        IEnumerable<string> types,
        CancellationToken cancellationToken);
}
