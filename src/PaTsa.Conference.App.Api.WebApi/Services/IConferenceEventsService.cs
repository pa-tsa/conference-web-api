using PaTsa.Conference.App.Api.WebApi.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PaTsa.Conference.App.Api.WebApi.Services;

public interface IConferenceEventsService : IMongoEntityService<ConferenceEvent>, IPingableService
{
    Task<List<ConferenceEvent>> FilterAsync(IEnumerable<string> types, CancellationToken cancellationToken);
}
