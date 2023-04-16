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
        MongoDbCollectionName) { }

    public async Task<List<ConferenceEvent>> FilterAsync(
        IEnumerable<string> eventIds,
        IEnumerable<string> types,
        CancellationToken cancellationToken = default)
    {
        var eventIdsFilterDefinitionList = eventIds
            .Select(eventId => Builders<ConferenceEvent>.Filter.Eq(_ => _.EventId, eventId))
            .ToList();

        var eventTypesFilterDefinitionList = types
            .Select(type => Builders<ConferenceEvent>.Filter.Eq(_ => _.Type, type))
            .ToList();

        var filterDefinition = FilterDefinition<ConferenceEvent>.Empty;

        if (eventIdsFilterDefinitionList.Any())
        {
            filterDefinition = Builders<ConferenceEvent>.Filter.Or(eventIdsFilterDefinitionList);
        }

        if (eventTypesFilterDefinitionList.Any())
        {
            filterDefinition = filterDefinition == FilterDefinition<ConferenceEvent>.Empty
                ? Builders<ConferenceEvent>.Filter.Or(eventTypesFilterDefinitionList)
                : Builders<ConferenceEvent>.Filter.And(
                    filterDefinition,
                    Builders<ConferenceEvent>.Filter.Or(eventTypesFilterDefinitionList));
        }

        var cursor = await EntityCollection.FindAsync(filterDefinition, null, cancellationToken);

        var result = await cursor.ToListAsync(cancellationToken);

        return result;
    }
}
