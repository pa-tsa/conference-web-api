using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
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

    public ConferenceEventsService(IMongoClient mongoClient, IOptions<ConferenceDatabase> options, ILogger<ConferenceEventsService> logger) : base(
        mongoClient,
        options.Value.DatabaseName,
        MongoDbCollectionName,
        logger)
    { }

    public async Task<List<ConferenceEvent>> FilterAsync(
        IEnumerable<string> eventIds,
        IEnumerable<string> types,
        CancellationToken cancellationToken = default)
    {
        var eventIdsFilterDefinitionList = eventIds
            .Select(eventId => Builders<ConferenceEvent>.Filter.Eq(conferenceEvent => conferenceEvent.EventId, eventId))
            .ToList();

        var eventTypesFilterDefinitionList = types
            .Select(type => Builders<ConferenceEvent>.Filter.Eq(conferenceEvent => conferenceEvent.Type, type))
            .ToList();

        var filterDefinition = FilterDefinition<ConferenceEvent>.Empty;

        if (eventIdsFilterDefinitionList.Count != 0)
        {
            filterDefinition = Builders<ConferenceEvent>.Filter.Or(eventIdsFilterDefinitionList);
        }

        if (eventTypesFilterDefinitionList.Count != 0)
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
