using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Moq;
using PaTsa.Conference.App.Api.UnitTests.Data;
using PaTsa.Conference.App.Api.UnitTests.ExtensionMethods;
using PaTsa.Conference.App.Api.UnitTests.Helpers;
using PaTsa.Conference.App.Api.WebApi.Configuration;
using PaTsa.Conference.App.Api.WebApi.Entities;
using PaTsa.Conference.App.Api.WebApi.Services;
using Xunit;

namespace PaTsa.Conference.App.Api.UnitTests.WebApi.Services;

[ExcludeFromCodeCoverage]
public class ConferenceEventsServiceTest
{
    private const string CollectionName = "conference-events";
    private const string DatabaseName = "conference-app-cosmosdb";

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public void Collection_Name_Should_Be_ConferenceEvents()
    {
        // Arrange
        var mockedMongoCollection = new Mock<IMongoCollection<ConferenceEvent>>();

        var mockedMongoDatabase = new Mock<IMongoDatabase>();
        mockedMongoDatabase
            .Setup(_ => _.GetCollection<ConferenceEvent>(It.Is<string>(collectionName => collectionName == CollectionName), null))
            .Returns(mockedMongoCollection.Object);

        var mockedMongoClient = new Mock<IMongoClient>();
        mockedMongoClient
            .Setup(_ => _.GetDatabase(It.Is<string>(databaseName => databaseName == DatabaseName), null))
            .Returns(mockedMongoDatabase.Object);

        var mockedPointOfSalesOptions = new Mock<IOptions<ConferenceDatabase>>();
        mockedPointOfSalesOptions
            .Setup(_ => _.Value)
            .Returns(new ConferenceDatabase
            {
                DatabaseName = DatabaseName
            });

        // Act
        var conferenceEventsService = new ConferenceEventsService(mockedMongoClient.Object, mockedPointOfSalesOptions.Object);

        // Assert
        Assert.Equal("conference-events", conferenceEventsService.CollectionName);
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public void Constructor_Should_Instantiate_Base_Class()
    {
        // Arrange
        var mockedMongoCollection = new Mock<IMongoCollection<ConferenceEvent>>();

        var mockedMongoDatabase = new Mock<IMongoDatabase>();
        mockedMongoDatabase
            .Setup(_ => _.GetCollection<ConferenceEvent>(It.Is<string>(collectionName => collectionName == CollectionName), null))
            .Returns(mockedMongoCollection.Object);

        var mockedMongoClient = new Mock<IMongoClient>();
        mockedMongoClient
            .Setup(_ => _.GetDatabase(It.Is<string>(databaseName => databaseName == DatabaseName), null))
            .Returns(mockedMongoDatabase.Object);

        var mockedPointOfSalesOptions = new Mock<IOptions<ConferenceDatabase>>();
        mockedPointOfSalesOptions
            .Setup(_ => _.Value)
            .Returns(new ConferenceDatabase
            {
                DatabaseName = DatabaseName
            });

        // Act
        var conferenceEventsService = new ConferenceEventsService(mockedMongoClient.Object, mockedPointOfSalesOptions.Object);

        // Assert
        Assert.NotNull(conferenceEventsService);
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public async void CreateAsync_Should_Insert_New_Entity()
    {
        // Arrange
        var conferenceEventsTestData = new ConferenceEventsTestData();

        var conferenceEvent =
            conferenceEventsTestData.First(_ => (ConferenceEventDataIssues)_[1] == ConferenceEventDataIssues.None)[0] as ConferenceEvent;

        var mockedMongoCollection = new Mock<IMongoCollection<ConferenceEvent>>();

        var mockedMongoDatabase = new Mock<IMongoDatabase>();
        mockedMongoDatabase
            .Setup(_ => _.GetCollection<ConferenceEvent>(It.Is<string>(collectionName => collectionName == CollectionName), null))
            .Returns(mockedMongoCollection.Object)
            .Verifiable();

        var mockedMongoClient = new Mock<IMongoClient>();
        mockedMongoClient
            .Setup(_ => _.GetDatabase(It.Is<string>(databaseName => databaseName == DatabaseName), null))
            .Returns(mockedMongoDatabase.Object)
            .Verifiable();

        var mockedPointOfSalesOptions = new Mock<IOptions<ConferenceDatabase>>();
        mockedPointOfSalesOptions
            .Setup(_ => _.Value)
            .Returns(new ConferenceDatabase
            {
                DatabaseName = DatabaseName
            });

        var conferenceEventsService = new ConferenceEventsService(mockedMongoClient.Object, mockedPointOfSalesOptions.Object);

        // Act
        await conferenceEventsService.CreateAsync(conferenceEvent!);

        // Assert
        mockedMongoCollection
            .Verify(_ =>
                _.InsertOneAsync(It.Is(conferenceEvent, new ConferenceEventEqualityComparer())!, null, CancellationToken.None), Times.Once);
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public async void ExistsAsync_Should_Return_True()
    {
        // Arrange
        var conferenceEventsTestData = new ConferenceEventsTestData();

        var expectedConferenceEvent = conferenceEventsTestData
            .Where(_ => (ConferenceEventDataIssues)_[1] == ConferenceEventDataIssues.None)
            .Select(_ => _[0])
            .Cast<ConferenceEvent>()
            .Last();

        var conferenceEvents = new List<ConferenceEvent>
        {
            expectedConferenceEvent
        };

        var mockedAsyncCursor = new Mock<IAsyncCursor<ConferenceEvent>>();
        mockedAsyncCursor.Setup(_ => _.Current).Returns(conferenceEvents);
        mockedAsyncCursor
            .SetupSequence(_ => _.MoveNextAsync(It.IsAny<CancellationToken>()))
            .ReturnsAsync(true)
            .ReturnsAsync(false);

        var filterDefinitionJson = Builders<ConferenceEvent>.Filter.Eq(_ => _.Id, expectedConferenceEvent.Id).RenderToJson();

        // If you get this error:
        // System.ArgumentNullException : Value cannot be null. (Parameter 'source')
        // The predicate for FindAsync changed and is causing an error
        var mockedMongoCollection = new Mock<IMongoCollection<ConferenceEvent>>();
        mockedMongoCollection
            .Setup(_ => _.FindAsync(
                It.Is<FilterDefinition<ConferenceEvent>>(filter => filter.RenderToJson().Equals(filterDefinitionJson)),
                It.IsAny<FindOptions<ConferenceEvent, ConferenceEvent>>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(mockedAsyncCursor.Object)
            .Verifiable();

        var mockedMongoDatabase = new Mock<IMongoDatabase>();
        mockedMongoDatabase
            .Setup(_ => _.GetCollection<ConferenceEvent>(It.Is<string>(collectionName => collectionName == CollectionName), null))
            .Returns(mockedMongoCollection.Object);

        var mockedMongoClient = new Mock<IMongoClient>();
        mockedMongoClient
            .Setup(_ => _.GetDatabase(It.Is<string>(databaseName => databaseName == DatabaseName), null))
            .Returns(mockedMongoDatabase.Object)
            .Verifiable();

        var mockedPointOfSalesOptions = new Mock<IOptions<ConferenceDatabase>>();
        mockedPointOfSalesOptions
            .Setup(_ => _.Value)
            .Returns(new ConferenceDatabase
            {
                DatabaseName = DatabaseName
            });

        var conferenceEventsService = new ConferenceEventsService(mockedMongoClient.Object, mockedPointOfSalesOptions.Object);

        // Act
        var result = await conferenceEventsService.ExistsAsync(expectedConferenceEvent.Id!);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData("Middle School")]
    [InlineData("Middle School", "High School")]
    [InlineData("Middle School", "Special Interest")]
    [InlineData("Middle School", "High School", "Special Interest")]
    [InlineData("High School", "Special Interest")]
    [Trait("TestCategory", "UnitTest")]
    public async void FilterAsync_Should_Filter_Entities_By_Type(params string[] types)
    {
        // Arrange
        Func<ConferenceEvent, bool> predicate = p => p.Type == types[0];

        for (var index = 1; index < types.Length; index++)
        {
            var oldPredicate = predicate;
            var value = types[index];
            // ReSharper disable once AccessToModifiedClosure
            predicate = p => oldPredicate(p) || p.Type == value;
        }

        var conferenceEventsTestData = new ConferenceEventsTestData();

        var expectedConferenceEvents = conferenceEventsTestData
            .Where(_ => (ConferenceEventDataIssues)_[1] == ConferenceEventDataIssues.None)
            .Select(_ => _[0])
            .Cast<ConferenceEvent>()
            .Where(predicate)
            .ToList();

        var mockedAsyncCursor = new Mock<IAsyncCursor<ConferenceEvent>>();
        mockedAsyncCursor.Setup(_ => _.Current).Returns(expectedConferenceEvents);
        mockedAsyncCursor
            .SetupSequence(_ => _.MoveNextAsync(It.IsAny<CancellationToken>()))
            .ReturnsAsync(true)
            .ReturnsAsync(false);

        var eventTypes = types.Select(type => Builders<ConferenceEvent>.Filter.Eq(_ => _.Type, type)).ToList();

        var filterDefinitionJson = Builders<ConferenceEvent>.Filter.Or(eventTypes).RenderToJson();

        // If you get this error:
        // System.ArgumentNullException : Value cannot be null. (Parameter 'source')
        // The predicate for FindAsync changed and is causing an error
        var mockedMongoCollection = new Mock<IMongoCollection<ConferenceEvent>>();
        mockedMongoCollection
            .Setup(_ => _.FindAsync(
                It.Is<FilterDefinition<ConferenceEvent>>(filter => filter.RenderToJson().Equals(filterDefinitionJson)),
                It.IsAny<FindOptions<ConferenceEvent, ConferenceEvent>>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(mockedAsyncCursor.Object)
            .Verifiable();

        var mockedMongoDatabase = new Mock<IMongoDatabase>();
        mockedMongoDatabase
            .Setup(_ => _.GetCollection<ConferenceEvent>(It.Is<string>(collectionName => collectionName == CollectionName), null))
            .Returns(mockedMongoCollection.Object);

        var mockedMongoClient = new Mock<IMongoClient>();
        mockedMongoClient
            .Setup(_ => _.GetDatabase(It.Is<string>(databaseName => databaseName == DatabaseName), null))
            .Returns(mockedMongoDatabase.Object)
            .Verifiable();

        var mockedPointOfSalesOptions = new Mock<IOptions<ConferenceDatabase>>();
        mockedPointOfSalesOptions
            .Setup(_ => _.Value)
            .Returns(new ConferenceDatabase
            {
                DatabaseName = DatabaseName
            });

        var conferenceEventsService = new ConferenceEventsService(mockedMongoClient.Object, mockedPointOfSalesOptions.Object);

        // Act
        var result = await conferenceEventsService.FilterAsync(types);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expectedConferenceEvents.Count, result.Count);
        Assert.Equal(expectedConferenceEvents, result, new ConferenceEventEqualityComparer());
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public async void GetAsync_Should_Get_All_Entities()
    {
        // Arrange
        var conferenceEventsTestData = new ConferenceEventsTestData();

        var conferenceEvents = conferenceEventsTestData
            .Where(_ => (ConferenceEventDataIssues)_[1] == ConferenceEventDataIssues.None)
            .Select(_ => _[0])
            .Cast<ConferenceEvent>()
            .ToList();

        var mockedAsyncCursor = new Mock<IAsyncCursor<ConferenceEvent>>();
        mockedAsyncCursor.Setup(_ => _.Current).Returns(conferenceEvents);
        mockedAsyncCursor
            .SetupSequence(_ => _.MoveNextAsync(It.IsAny<CancellationToken>()))
            .ReturnsAsync(true)
            .ReturnsAsync(false);

        // If you get this error:
        // System.ArgumentNullException : Value cannot be null. (Parameter 'source')
        // The predicate for FindAsync changed and is causing an error
        var mockedMongoCollection = new Mock<IMongoCollection<ConferenceEvent>>();
        mockedMongoCollection
            .Setup(_ => _.FindAsync(
                Builders<ConferenceEvent>.Filter.Empty,
                It.IsAny<FindOptions<ConferenceEvent, ConferenceEvent>>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(mockedAsyncCursor.Object)
            .Verifiable();

        var mockedMongoDatabase = new Mock<IMongoDatabase>();
        mockedMongoDatabase
            .Setup(_ => _.GetCollection<ConferenceEvent>(It.Is<string>(collectionName => collectionName == CollectionName), null))
            .Returns(mockedMongoCollection.Object);

        var mockedMongoClient = new Mock<IMongoClient>();
        mockedMongoClient
            .Setup(_ => _.GetDatabase(It.Is<string>(databaseName => databaseName == DatabaseName), null))
            .Returns(mockedMongoDatabase.Object)
            .Verifiable();

        var mockedPointOfSalesOptions = new Mock<IOptions<ConferenceDatabase>>();
        mockedPointOfSalesOptions
            .Setup(_ => _.Value)
            .Returns(new ConferenceDatabase
            {
                DatabaseName = DatabaseName
            });

        var conferenceEventsService = new ConferenceEventsService(mockedMongoClient.Object, mockedPointOfSalesOptions.Object);

        // Act
        var result = await conferenceEventsService.GetAsync();

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal(conferenceEvents.Count, result.Count);
        Assert.Equal(conferenceEvents, result, new ConferenceEventEqualityComparer());
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public async void GetAsync_Should_Get_Entity_By_Id()
    {
        // Arrange
        var conferenceEventsTestData = new ConferenceEventsTestData();

        var expectedConferenceEvent = conferenceEventsTestData
            .Where(_ => (ConferenceEventDataIssues)_[1] == ConferenceEventDataIssues.None)
            .Select(_ => _[0])
            .Cast<ConferenceEvent>()
            .Last();

        var conferenceEvents = new List<ConferenceEvent>
        {
            expectedConferenceEvent
        };

        var mockedAsyncCursor = new Mock<IAsyncCursor<ConferenceEvent>>();
        mockedAsyncCursor.Setup(_ => _.Current).Returns(conferenceEvents);
        mockedAsyncCursor
            .SetupSequence(_ => _.MoveNextAsync(It.IsAny<CancellationToken>()))
            .ReturnsAsync(true)
            .ReturnsAsync(false);

        var filterDefinitionJson = Builders<ConferenceEvent>.Filter.Eq(_ => _.Id, expectedConferenceEvent.Id).RenderToJson();

        // If you get this error:
        // System.ArgumentNullException : Value cannot be null. (Parameter 'source')
        // The predicate for FindAsync changed and is causing an error
        var mockedMongoCollection = new Mock<IMongoCollection<ConferenceEvent>>();
        mockedMongoCollection
            .Setup(_ => _.FindAsync(
                It.Is<FilterDefinition<ConferenceEvent>>(filter => filter.RenderToJson().Equals(filterDefinitionJson)),
                It.IsAny<FindOptions<ConferenceEvent, ConferenceEvent>>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(mockedAsyncCursor.Object)
            .Verifiable();

        var mockedMongoDatabase = new Mock<IMongoDatabase>();
        mockedMongoDatabase
            .Setup(_ => _.GetCollection<ConferenceEvent>(It.Is<string>(collectionName => collectionName == CollectionName), null))
            .Returns(mockedMongoCollection.Object);

        var mockedMongoClient = new Mock<IMongoClient>();
        mockedMongoClient
            .Setup(_ => _.GetDatabase(It.Is<string>(databaseName => databaseName == DatabaseName), null))
            .Returns(mockedMongoDatabase.Object)
            .Verifiable();

        var mockedPointOfSalesOptions = new Mock<IOptions<ConferenceDatabase>>();
        mockedPointOfSalesOptions
            .Setup(_ => _.Value)
            .Returns(new ConferenceDatabase
            {
                DatabaseName = DatabaseName
            });

        var conferenceEventsService = new ConferenceEventsService(mockedMongoClient.Object, mockedPointOfSalesOptions.Object);

        // Act
        var result = await conferenceEventsService.GetAsync(expectedConferenceEvent.Id!);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expectedConferenceEvent, result, new ConferenceEventEqualityComparer());
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public async void GetAsync_Should_Get_Entity_By_Ids()
    {
        // Arrange
        var conferenceEventsTestData = new ConferenceEventsTestData();

        var expectedConferenceEvents = conferenceEventsTestData
            .Where(_ => (ConferenceEventDataIssues)_[1] == ConferenceEventDataIssues.None)
            .Select(_ => _[0])
            .Cast<ConferenceEvent>()
            .ToList();

        var ids = expectedConferenceEvents.Select(_ => _.Id).Cast<string>().ToList();

        var mockedAsyncCursor = new Mock<IAsyncCursor<ConferenceEvent>>();
        mockedAsyncCursor.Setup(_ => _.Current).Returns(expectedConferenceEvents);
        mockedAsyncCursor
            .SetupSequence(_ => _.MoveNextAsync(It.IsAny<CancellationToken>()))
            .ReturnsAsync(true)
            .ReturnsAsync(false);

        var filterDefinitionJson = Builders<ConferenceEvent>.Filter.In(_ => _.Id, ids).RenderToJson();

        // If you get this error:
        // System.ArgumentNullException : Value cannot be null. (Parameter 'source')
        // The predicate for FindAsync changed and is causing an error
        var mockedMongoCollection = new Mock<IMongoCollection<ConferenceEvent>>();
        mockedMongoCollection
            .Setup(_ => _.FindAsync(
                It.Is<FilterDefinition<ConferenceEvent>>(filter => filter.RenderToJson().Equals(filterDefinitionJson)),
                It.IsAny<FindOptions<ConferenceEvent, ConferenceEvent>>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(mockedAsyncCursor.Object)
            .Verifiable();

        var mockedMongoDatabase = new Mock<IMongoDatabase>();
        mockedMongoDatabase
            .Setup(_ => _.GetCollection<ConferenceEvent>(It.Is<string>(collectionName => collectionName == CollectionName), null))
            .Returns(mockedMongoCollection.Object);

        var mockedMongoClient = new Mock<IMongoClient>();
        mockedMongoClient
            .Setup(_ => _.GetDatabase(It.Is<string>(databaseName => databaseName == DatabaseName), null))
            .Returns(mockedMongoDatabase.Object)
            .Verifiable();

        var mockedPointOfSalesOptions = new Mock<IOptions<ConferenceDatabase>>();
        mockedPointOfSalesOptions
            .Setup(_ => _.Value)
            .Returns(new ConferenceDatabase
            {
                DatabaseName = DatabaseName
            });

        var conferenceEventsService = new ConferenceEventsService(mockedMongoClient.Object, mockedPointOfSalesOptions.Object);

        // Act
        var result = await conferenceEventsService.GetAsync(ids);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expectedConferenceEvents.Count, result.Count);
        Assert.Equal(expectedConferenceEvents, result, new ConferenceEventEqualityComparer());
    }


    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public async void Ping_Should_Return_False()
    {
        // Arrange
        var mockedMongoDatabase = new Mock<IMongoDatabase>();

        var mockedMongoClient = new Mock<IMongoClient>();
        mockedMongoClient
            .Setup(_ => _.GetDatabase(It.Is<string>(databaseName => databaseName == DatabaseName), null))
            .Returns(mockedMongoDatabase.Object)
            .Verifiable();

        var mockedPointOfSalesOptions = new Mock<IOptions<ConferenceDatabase>>();
        mockedPointOfSalesOptions
            .Setup(_ => _.Value)
            .Returns(new ConferenceDatabase
            {
                DatabaseName = DatabaseName
            });

        var conferenceEventsService = new ConferenceEventsService(mockedMongoClient.Object, mockedPointOfSalesOptions.Object);

        // Act
        var result = await conferenceEventsService.PingAsync();

        // Assert
        Assert.False(result);
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public async void Ping_Should_Return_True()
    {
        // Arrange
        var mockedMongoCollection = new Mock<IMongoCollection<ConferenceEvent>>();
        var mockedMongoDatabase = new Mock<IMongoDatabase>();

        mockedMongoCollection
            .Setup(_ => _.Database)
            .Returns(mockedMongoDatabase.Object);

        mockedMongoDatabase
            .Setup(_ => _.GetCollection<ConferenceEvent>(It.Is<string>(collectionName => collectionName == CollectionName), null))
            .Returns(mockedMongoCollection.Object);

        var mockedMongoClient = new Mock<IMongoClient>();
        mockedMongoClient
            .Setup(_ => _.GetDatabase(It.Is<string>(databaseName => databaseName == DatabaseName), null))
            .Returns(mockedMongoDatabase.Object)
            .Verifiable();

        var mockedPointOfSalesOptions = new Mock<IOptions<ConferenceDatabase>>();
        mockedPointOfSalesOptions
            .Setup(_ => _.Value)
            .Returns(new ConferenceDatabase
            {
                DatabaseName = DatabaseName
            });

        var conferenceEventsService = new ConferenceEventsService(mockedMongoClient.Object, mockedPointOfSalesOptions.Object);

        // Act
        var result = await conferenceEventsService.PingAsync();

        // Assert
        Assert.True(result);
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public async void RemoveAsync_Should_Delete_Entity_By_Id()
    {
        // Arrange
        var conferenceEventsTestData = new ConferenceEventsTestData();

        var expectedConferenceEvent = conferenceEventsTestData
            .Where(_ => (ConferenceEventDataIssues)_[1] == ConferenceEventDataIssues.None)
            .Select(_ => _[0])
            .Cast<ConferenceEvent>()
            .Last();

        var expectedFilterDefinitionJson = Builders<ConferenceEvent>.Filter.Eq(_ => _.Id, expectedConferenceEvent.Id).RenderToJson();

        Func<FilterDefinition<ConferenceEvent>, bool> validateFilterDefinitionFunc = filterDefinition =>
        {
            var filterDefinitionJson = filterDefinition.RenderToJson();

            return expectedFilterDefinitionJson == filterDefinitionJson;
        };

        // If you get this error:
        // System.ArgumentNullException : Value cannot be null. (Parameter 'source')
        // The predicate for FindAsync changed and is causing an error
        var mockedMongoCollection = new Mock<IMongoCollection<ConferenceEvent>>();

        var mockedMongoDatabase = new Mock<IMongoDatabase>();
        mockedMongoDatabase
            .Setup(_ => _.GetCollection<ConferenceEvent>(It.Is<string>(collectionName => collectionName == CollectionName), null))
            .Returns(mockedMongoCollection.Object);

        var mockedMongoClient = new Mock<IMongoClient>();
        mockedMongoClient
            .Setup(_ => _.GetDatabase(It.Is<string>(databaseName => databaseName == DatabaseName), null))
            .Returns(mockedMongoDatabase.Object)
            .Verifiable();

        var mockedPointOfSalesOptions = new Mock<IOptions<ConferenceDatabase>>();
        mockedPointOfSalesOptions
            .Setup(_ => _.Value)
            .Returns(new ConferenceDatabase
            {
                DatabaseName = DatabaseName
            });

        var conferenceEventsService = new ConferenceEventsService(mockedMongoClient.Object, mockedPointOfSalesOptions.Object);

        // Act
        await conferenceEventsService.RemoveAsync(expectedConferenceEvent);

        // Assert
        mockedMongoCollection
            .Verify(_ => _.DeleteOneAsync(
                    It.Is<FilterDefinition<ConferenceEvent>>(fd => validateFilterDefinitionFunc(fd)),
                    null,
                    It.IsAny<CancellationToken>()),
                Times.Once);
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public void ServiceName_Name_Should_Be_ConferenceEvents()
    {
        // Arrange
        var mockedMongoCollection = new Mock<IMongoCollection<ConferenceEvent>>();

        var mockedMongoDatabase = new Mock<IMongoDatabase>();
        mockedMongoDatabase
            .Setup(_ => _.GetCollection<ConferenceEvent>(It.Is<string>(collectionName => collectionName == CollectionName), null))
            .Returns(mockedMongoCollection.Object);

        var mockedMongoClient = new Mock<IMongoClient>();
        mockedMongoClient
            .Setup(_ => _.GetDatabase(It.Is<string>(databaseName => databaseName == DatabaseName), null))
            .Returns(mockedMongoDatabase.Object);

        var mockedPointOfSalesOptions = new Mock<IOptions<ConferenceDatabase>>();
        mockedPointOfSalesOptions
            .Setup(_ => _.Value)
            .Returns(new ConferenceDatabase
            {
                DatabaseName = DatabaseName
            });

        // Act
        var conferenceEventsService = new ConferenceEventsService(mockedMongoClient.Object, mockedPointOfSalesOptions.Object);

        // Assert
        Assert.Equal("ConferenceEvents", conferenceEventsService.ServiceName);
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public async void UpdateAsync_Should_Replace_Entity_By_Id()
    {
        // Arrange
        var conferenceEventsTestData = new ConferenceEventsTestData();

        var expectedConferenceEvent = conferenceEventsTestData
            .Where(_ => (ConferenceEventDataIssues)_[1] == ConferenceEventDataIssues.None)
            .Select(_ => _[0])
            .Cast<ConferenceEvent>()
            .Last();

        var expectedFilterDefinitionJson = Builders<ConferenceEvent>.Filter.Eq(_ => _.Id, expectedConferenceEvent.Id).RenderToJson();

        Func<FilterDefinition<ConferenceEvent>, bool> validateFilterDefinitionFunc = filterDefinition =>
        {
            var filterDefinitionJson = filterDefinition.RenderToJson();

            return expectedFilterDefinitionJson == filterDefinitionJson;
        };

        var mockedMongoCollection = new Mock<IMongoCollection<ConferenceEvent>>();

        var mockedMongoDatabase = new Mock<IMongoDatabase>();
        mockedMongoDatabase
            .Setup(_ => _.GetCollection<ConferenceEvent>(It.Is<string>(collectionName => collectionName == CollectionName), null))
            .Returns(mockedMongoCollection.Object);

        var mockedMongoClient = new Mock<IMongoClient>();
        mockedMongoClient
            .Setup(_ => _.GetDatabase(It.Is<string>(databaseName => databaseName == DatabaseName), null))
            .Returns(mockedMongoDatabase.Object)
            .Verifiable();

        var mockedPointOfSalesOptions = new Mock<IOptions<ConferenceDatabase>>();
        mockedPointOfSalesOptions
            .Setup(_ => _.Value)
            .Returns(new ConferenceDatabase
            {
                DatabaseName = DatabaseName
            });

        var conferenceEventsService = new ConferenceEventsService(mockedMongoClient.Object, mockedPointOfSalesOptions.Object);

        // Act
        await conferenceEventsService.UpdateAsync(expectedConferenceEvent, default);

        // Assert
        mockedMongoCollection
            .Verify(_ => _.ReplaceOneAsync(
                    It.Is<FilterDefinition<ConferenceEvent>>(fd => validateFilterDefinitionFunc(fd)),
                    expectedConferenceEvent,
                    It.IsAny<ReplaceOptions>(),
                    It.IsAny<CancellationToken>()),
                Times.Once);
    }
}
