using System.Diagnostics.CodeAnalysis;
using System.Linq;
using PaTsa.Conference.App.Api.UnitTests.Data;
using PaTsa.Conference.App.Api.WebApi.Entities;
using Xunit;

namespace PaTsa.Conference.App.Api.UnitTests.WebApi.Entities;

[ExcludeFromCodeCoverage]
public class EntityExtensionsTests
{
    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public void ToModel_For_ConferenceEvent_Should_Return_ConferenceEventModel()
    {
        // Arrange
        var conferenceEventsTestData = new ConferenceEventsTestData();

        var conferenceEvent = conferenceEventsTestData
            .First(_ => (ConferenceEventDataIssues)_[1] == ConferenceEventDataIssues.None)[0] as ConferenceEvent;

        Assert.NotNull(conferenceEvent);

        // Act
        var conferenceEventModel = conferenceEvent.ToModel();

        // Assert
        Assert.Equal(conferenceEvent.Description, conferenceEventModel.Description);
        Assert.Equal(conferenceEvent.EndDateTime, conferenceEventModel.EndDateTime);
        Assert.Equal(conferenceEvent.Id, conferenceEventModel.Id);
        Assert.Equal(conferenceEvent.Location, conferenceEventModel.Location);
        Assert.Equal(conferenceEvent.Name, conferenceEventModel.Name);
        Assert.Equal(conferenceEvent.StartDateTime, conferenceEventModel.StartDateTime);
        Assert.Equal(conferenceEvent.Type, conferenceEventModel.Type);
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public void ToModels_For_List_Of_ConferenceEvent_Should_Return_List_Of_ConferenceEventModel()
    {
        // Arrange
        var conferenceEventsTestData = new ConferenceEventsTestData();

        var conferenceEvents = conferenceEventsTestData
            .Where(_ => (ConferenceEventDataIssues)_[1] == ConferenceEventDataIssues.None)
            .Take(5)
            .Select(_ => _[0] as ConferenceEvent)
            .Cast<ConferenceEvent>()
            .ToList();

        // Act
        var conferenceEventModels = conferenceEvents.ToModels();

        Assert.Equal(conferenceEvents.Count, conferenceEventModels.Count);

        // Assert
        foreach (var conferenceEventModel in conferenceEventModels)
        {
            Assert.NotNull(conferenceEventModel);

            var conferenceEvent = conferenceEvents.SingleOrDefault(_ => _.Id == conferenceEventModel.Id);

            Assert.NotNull(conferenceEvent);

            Assert.Equal(conferenceEvent.Description, conferenceEventModel.Description);
            Assert.Equal(conferenceEvent.EndDateTime, conferenceEventModel.EndDateTime);
            Assert.Equal(conferenceEvent.Location, conferenceEventModel.Location);
            Assert.Equal(conferenceEvent.Name, conferenceEventModel.Name);
            Assert.Equal(conferenceEvent.StartDateTime, conferenceEventModel.StartDateTime);
            Assert.Equal(conferenceEvent.Type, conferenceEventModel.Type);
        }
    }
}
