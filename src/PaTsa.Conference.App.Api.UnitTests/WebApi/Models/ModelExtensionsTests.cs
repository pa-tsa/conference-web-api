using System;
using System.Diagnostics.CodeAnalysis;
using PaTsa.Conference.App.Api.WebApi.Models;
using Xunit;

namespace PaTsa.Conference.App.Api.UnitTests.WebApi.Models;

[ExcludeFromCodeCoverage]
public class ModelExtensionsTests
{
    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public void ToEntity_For_ConferenceEventModel_Should_Return_ConferenceEvent()
    {
        // Arrange
        var conferenceEventModel = new ConferenceEventModel
        {
            Description = "Sign-up",
            EndDateTime = DateTime.Parse("4/19/2023 18:30"),
            Id = "000000000000000000000001",
            Location = "Online Sign Up",
            Name = "Animatronics",
            StartDateTime = DateTime.Parse("4/19/2023 17:00"),
            Type = "High School"
        };

        Assert.NotNull(conferenceEventModel);

        // Act
        var conferenceEvent = conferenceEventModel.ToEntity();

        // Assert
        Assert.Equal(conferenceEventModel.Description, conferenceEvent.Description);
        Assert.Equal(conferenceEventModel.EndDateTime, conferenceEvent.EndDateTime);
        Assert.Equal(conferenceEventModel.Id, conferenceEvent.Id);
        Assert.Equal(conferenceEventModel.Location, conferenceEvent.Location);
        Assert.Equal(conferenceEventModel.Name, conferenceEvent.Name);
        Assert.Equal(conferenceEventModel.StartDateTime, conferenceEvent.StartDateTime);
        Assert.Equal(conferenceEventModel.Type, conferenceEvent.Type);
    }
}
