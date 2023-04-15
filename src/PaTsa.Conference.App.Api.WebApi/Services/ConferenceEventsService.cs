using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PaTsa.Conference.App.Api.WebApi.Configuration;
using PaTsa.Conference.App.Api.WebApi.Entities;

namespace PaTsa.Conference.App.Api.WebApi.Services;

public class ConferenceEventsService : MongoDbService<ConferenceEvent>, IConferenceEventsService
{
    public const string MongoDbCollectionName = "conference-events";

    public string CollectionName => MongoDbCollectionName;

    public string ServiceName => "ConferenceEvents";

    public ConferenceEventsService(IMongoClient mongoClient, IOptions<ConferenceDatabase> options) : base(
        mongoClient,
        options.Value.DatabaseName,
        MongoDbCollectionName)
    { }

    public async Task<List<ConferenceEvent>> FilterAsync(IEnumerable<string> types, CancellationToken cancellationToken = default)
    {
        var eventTypes = types.Select(type => Builders<ConferenceEvent>.Filter.Eq(_ => _.Type, type)).ToList();

        var filterDefinitions = Builders<ConferenceEvent>.Filter.Or(eventTypes);

        var cursor = await EntityCollection.FindAsync(filterDefinitions, null, cancellationToken);

        var result = await cursor.ToListAsync(cancellationToken);

        return result;
    }
}
