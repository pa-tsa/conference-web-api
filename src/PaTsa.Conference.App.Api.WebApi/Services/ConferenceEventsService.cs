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
}
