using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PaTsa.Conference.App.Api.WebApi.Entities;

public class ConferenceEvent : IMongoDbEntity
{
    public string? Description { get; set; }

    public DateTime EndDateTime { get; set; }

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string? Location { get; set; }

    public string? Name { get; set; }

    public DateTime StartDateTime { get; set; }

    public string? Type { get; set; }
}
