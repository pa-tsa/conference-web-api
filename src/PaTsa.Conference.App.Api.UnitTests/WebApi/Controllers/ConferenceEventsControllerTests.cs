using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PaTsa.Conference.App.Api.UnitTests.Data;
using PaTsa.Conference.App.Api.UnitTests.Helpers;
using PaTsa.Conference.App.Api.WebApi.Controllers;
using PaTsa.Conference.App.Api.WebApi.Entities;
using PaTsa.Conference.App.Api.WebApi.Models;
using PaTsa.Conference.App.Api.WebApi.Services;
using Xunit;

namespace PaTsa.Conference.App.Api.UnitTests.WebApi.Controllers;

[ExcludeFromCodeCoverage]
public class ConferenceEventsControllerTests
{
    [Theory]
    [InlineData(5, 1, 10)]
    [InlineData(10, 2, 10)]
    [InlineData(30, 2, 10)]
    [Trait("TestCategory", "UnitTest")]
    public async void Get_Should_Return_Ok_Regardless_Of_Pagination(int take, int pageNumber, int pageSize)
    {
        // Arrange
        var conferenceEventsTestData = new ConferenceEventsTestData();

        var conferenceEvents = conferenceEventsTestData
            .Where(_ => (ConferenceEventDataIssues)_[1] == ConferenceEventDataIssues.None)
            .Select(_ => _[0])
            .Cast<ConferenceEvent>()
            .Take(take)
            .ToList();

        var mockedConferenceEventsService = new Mock<IConferenceEventsService>();
        mockedConferenceEventsService
            .Setup(_ => _.GetAsync(default))
            .ReturnsAsync(conferenceEvents);

        var conferenceEventsController = new ConferenceEventsController(mockedConferenceEventsService.Object);

        // Act
        var actionResult = await conferenceEventsController.Get(pageNumber, pageSize);

        Assert.NotNull(actionResult);

        var conferenceEventModels = actionResult.Value;
        Assert.NotNull(conferenceEventModels);
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public void Controller_Public_Methods_Should_Have_Http_Method_Attribute()
    {
        var conferenceEventsControllerType = typeof(ConferenceEventsController);

        var methodInfos = conferenceEventsControllerType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);

        Assert.NotEmpty(methodInfos);

        foreach (var methodInfo in methodInfos)
        {
            // Needs to be nullable so the compiler sees it's initialized
            // The Assert.Fail doesn't tell it that the line it's being used
            // will only ever be hit if it's initialized
            Type? attributeType = null;

            switch (methodInfo.Name.ToLower())
            {
                case "delete":
                    attributeType = typeof(HttpDeleteAttribute);
                    break;
                case "get":
                    attributeType = typeof(HttpGetAttribute);
                    break;
                case "head":
                    attributeType = typeof(HttpHeadAttribute);
                    break;
                case "options":
                    attributeType = typeof(HttpOptionsAttribute);
                    break;
                case "patch":
                    attributeType = typeof(HttpPatchAttribute);
                    break;
                case "post":
                    attributeType = typeof(HttpPostAttribute);
                    break;
                case "put":
                    attributeType = typeof(HttpPutAttribute);
                    break;
                default:
                    Assert.Fail("Unsupported public HTTP operation");
                    break;
            }

            var attributes = methodInfo.GetCustomAttributes(attributeType, false);

            Assert.NotNull(attributes);
            Assert.NotEmpty(attributes);
            Assert.Single(attributes);
        }
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public void Controller_Should_Have_ApiController_Attribute()
    {
        var conferenceEventsControllerType = typeof(ConferenceEventsController);

        var attributes = conferenceEventsControllerType.GetCustomAttributes(typeof(ApiControllerAttribute), false);

        Assert.NotNull(attributes);
        Assert.NotEmpty(attributes);
        Assert.Single(attributes);
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public void Controller_Should_Have_Produces_Attribute()
    {
        var conferenceEventsControllerType = typeof(ConferenceEventsController);

        var attributes = conferenceEventsControllerType.GetCustomAttributes(typeof(ProducesAttribute), false);

        Assert.NotNull(attributes);
        Assert.NotEmpty(attributes);
        Assert.Single(attributes);

        var producesAttribute = (ProducesAttribute)attributes[0];

        Assert.Contains("application/json", producesAttribute.ContentTypes);
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public void Controller_Should_Have_Route_Attribute()
    {
        var conferenceEventsControllerType = typeof(ConferenceEventsController);

        var attributes = conferenceEventsControllerType.GetCustomAttributes(typeof(RouteAttribute), false);

        Assert.NotNull(attributes);
        Assert.NotEmpty(attributes);
        Assert.Single(attributes);

        var routeAttribute = (RouteAttribute)attributes[0];

        Assert.Equal("api/[controller]", routeAttribute.Template);
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public async void Get_Should_Return_Ok_When_Empty()
    {
        // Arrange
        var mockedConferenceEventsService = new Mock<IConferenceEventsService>();
        mockedConferenceEventsService
            .Setup(_ => _.GetAsync(default))
            .ReturnsAsync(new List<ConferenceEvent>(0));

        var conferenceEventsController = new ConferenceEventsController(mockedConferenceEventsService.Object);

        // Act
        var actionResult = await conferenceEventsController.Get();

        Assert.NotNull(actionResult);

        var conferenceEventModels = actionResult.Value;
        Assert.NotNull(conferenceEventModels);
        Assert.Empty(conferenceEventModels);
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public async void Get_Should_Return_Ok_With_Default_PageNumber_And_PageSize()
    {
        // Arrange
        var conferenceEventsTestData = new ConferenceEventsTestData();

        var conferenceEvents = conferenceEventsTestData
            .Where(_ => (ConferenceEventDataIssues)_[1] == ConferenceEventDataIssues.None)
            .Select(_ => _[0])
            .Cast<ConferenceEvent>()
            .ToList();

        var mockedConferenceEventsService = new Mock<IConferenceEventsService>();
        mockedConferenceEventsService
            .Setup(_ => _.GetAsync(default))
            .ReturnsAsync(conferenceEvents);

        var conferenceEventsController = new ConferenceEventsController(mockedConferenceEventsService.Object);

        // Act
        var actionResult = await conferenceEventsController.Get();

        Assert.NotNull(actionResult);

        var conferenceEventModels = actionResult.Value;
        Assert.NotNull(conferenceEventModels);
        Assert.NotEmpty(conferenceEventModels);
        Assert.Equal(25, conferenceEventModels.Count);
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public async void Get_Should_Return_Ok_With_Results_Paged()
    {
        // Arrange
        var conferenceEventsTestData = new ConferenceEventsTestData();

        const int pageNumber = 2;
        const int pageSize = 20;

        var conferenceEvents = conferenceEventsTestData
            .Where(_ => (ConferenceEventDataIssues)_[1] == ConferenceEventDataIssues.None)
            .Select(_ => _[0])
            .Cast<ConferenceEvent>()
            .ToList();

        var pagedConferenceEventModels = conferenceEvents
            .ToModels()
            // This is the logic
            // But since we hard coded pageNumber to 2
            // Optimizer doesn't like this statement
            //.Skip((pageNumber - 1) * pageSize)
            .Skip(pageSize)
            .Take(pageSize)
            .ToList();

        var mockedConferenceEventsService = new Mock<IConferenceEventsService>();
        mockedConferenceEventsService
            .Setup(_ => _.GetAsync(default))
            .ReturnsAsync(conferenceEvents);

        var conferenceEventsController = new ConferenceEventsController(mockedConferenceEventsService.Object);

        // Act
        var actionResult = await conferenceEventsController.Get(pageNumber, pageSize);

        Assert.NotNull(actionResult);

        var conferenceEventModels = actionResult.Value;
        Assert.NotNull(conferenceEventModels);
        Assert.Equal(pagedConferenceEventModels, conferenceEventModels, new ConferenceEventModelEqualityComparer());
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public async void Post_Should_Return_Created()
    {
        // Arrange
        var conferenceEventsTestData = new ConferenceEventsTestData();

        var conferenceEvent = (ConferenceEvent)conferenceEventsTestData.First(_ => (ConferenceEventDataIssues)_[1] == ConferenceEventDataIssues.None)[0];

        conferenceEvent.Id = null;

        var newConferenceEventModel = conferenceEvent.ToModel();

        var mockedConferenceEventsService = new Mock<IConferenceEventsService>();

        var conferenceEventsController = new ConferenceEventsController(mockedConferenceEventsService.Object);

        // Act
        var createdAtActionResult = await conferenceEventsController.Post(newConferenceEventModel);

        // Assert
        Assert.NotNull(createdAtActionResult);

        Assert.IsType<ConferenceEventModel>(createdAtActionResult.Value);

        mockedConferenceEventsService.Verify(_ => _.CreateAsync(It.Is(conferenceEvent, new ConferenceEventEqualityComparer()), default), Times.Once);
    }
}
