using System.Collections.Generic;
using System.Linq;
using PaTsa.Conference.App.Api.WebApi.Models;

namespace PaTsa.Conference.App.Api.WebApi.Entities;

public static class EntityExtensions
{
    public static ConferenceEventModel ToModel(this ConferenceEvent conferenceEvent)
    {
        return new ConferenceEventModel
        {
            Description = conferenceEvent.Description,
            EndDateTime = conferenceEvent.EndDateTime,
            EventId = conferenceEvent.EventId,
            Id = conferenceEvent.Id,
            Location = conferenceEvent.Location,
            Name = conferenceEvent.Name,
            StartDateTime = conferenceEvent.StartDateTime,
            Type = conferenceEvent.Type
        };
    }

    public static List<ConferenceEventModel> ToModels(this IList<ConferenceEvent> conferenceEvents)
    {
        return conferenceEvents.Select(conferenceEvent => conferenceEvent.ToModel()).ToList();
    }
}
