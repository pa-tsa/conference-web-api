using PaTsa.Conference.App.Api.WebApi.Entities;

namespace PaTsa.Conference.App.Api.WebApi.Models;

public static class ModelExtensions
{
    public static ConferenceEvent ToEntity(this ConferenceEventModel conferenceEventModel, bool ignoreId = false)
    {
        return new ConferenceEvent
        {
            Description = conferenceEventModel.Description,
            EndDateTime = conferenceEventModel.EndDateTime,
            EventId = conferenceEventModel.EventId,
            Id = ignoreId ? null : conferenceEventModel.Id,
            Location = conferenceEventModel.Location,
            Name = conferenceEventModel.Name,
            StartDateTime = conferenceEventModel.StartDateTime,
            Type = conferenceEventModel.Type
        };
    }
}
