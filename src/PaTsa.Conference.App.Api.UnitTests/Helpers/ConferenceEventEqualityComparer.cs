using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using PaTsa.Conference.App.Api.WebApi.Entities;

namespace PaTsa.Conference.App.Api.UnitTests.Helpers;

[ExcludeFromCodeCoverage]
internal class ConferenceEventEqualityComparer : IEqualityComparer<ConferenceEvent?>, IEqualityComparer<IList<ConferenceEvent>?>
{
    public bool Equals(ConferenceEvent? x, ConferenceEvent? y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (x is null) return false;
        if (y is null) return false;

        var descriptionsMatch = x.Description == y.Description;
        var endDateTimesMatch = x.EndDateTime == y.EndDateTime;
        var eventIdsMatch = x.EventId == y.EventId;
        var idsMatch = x.Id == y.Id;
        var locationsMatch = x.Location == y.Location;
        var namesMatch = x.Name == y.Name;
        var startDateTimesMatch = x.StartDateTime == y.StartDateTime;
        var typesMatch = x.Type == y.Type;

        return descriptionsMatch &&
               endDateTimesMatch &&
               eventIdsMatch &&
               idsMatch &&
               locationsMatch &&
               namesMatch &&
               startDateTimesMatch &&
               typesMatch;
    }

    public bool Equals(IList<ConferenceEvent>? x, IList<ConferenceEvent>? y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (x is null) return false;
        if (y is null) return false;
        if (x.Count != y.Count) return false;

        foreach (var leftConferenceEvent in x)
        {
            var rightConferenceEvent = y.SingleOrDefault(_ => _.Id == leftConferenceEvent.Id);

            if (!Equals(leftConferenceEvent, rightConferenceEvent)) return false;
        }

        return true;
    }

    public int GetHashCode(ConferenceEvent? obj)
    {
        return obj == null ? 0 : obj.GetHashCode();
    }

    public int GetHashCode(IList<ConferenceEvent>? obj)
    {
        return obj == null ? 0 : obj.GetHashCode();
    }
}
