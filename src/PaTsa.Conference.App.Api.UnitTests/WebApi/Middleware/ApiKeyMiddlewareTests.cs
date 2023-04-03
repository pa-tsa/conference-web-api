using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using PaTsa.Conference.App.Api.WebApi.Middleware;
using Xunit;

namespace PaTsa.Conference.App.Api.UnitTests.WebApi.Middleware;

[ExcludeFromCodeCoverage]
public class ApiKeyMiddlewareTests
{
    private const string ApiKey = "apikey";

    [Theory]
    [InlineData("/")]
    [InlineData("/api/stuff")]
    [InlineData("/api/stuff/with/long/route")]
    [InlineData("/not/api/route")]
    [InlineData(null)]
    [Trait("TestCategory", "UnitTest")]
    public async void ApiKeyMiddleware_Should_Return_Ok_For_Routes_When_Authorized(string? path)
    {
        // Arrange
        var mockedConfigurationSection = new Mock<IConfigurationSection>();
        mockedConfigurationSection
            .Setup(_ => _.Value)
            .Returns(ApiKey);

        var mockedConfiguration = new Mock<IConfiguration>();
        mockedConfiguration
            .Setup(_ => _.GetSection(It.Is(ApiKeyMiddleware.ApiKeyConfigValue, StringComparer.Ordinal)))
            .Returns(mockedConfigurationSection.Object);

        var serviceCollection = new ServiceCollection();
        serviceCollection.AddScoped(_ => mockedConfiguration.Object);

        var defaultContext = new DefaultHttpContext
        {
            Response = { Body = new MemoryStream() },
            Request = { Path = new PathString(path) },
            RequestServices = serviceCollection.BuildServiceProvider()
        };

        defaultContext.Request.Headers.Add(ApiKeyMiddleware.ApiHeaderKey, ApiKey);

        var apiKeyMiddleware = new ApiKeyMiddleware(_ => Task.CompletedTask);

        // Act
        await apiKeyMiddleware.InvokeAsync(defaultContext);

        // Assert
        Assert.Equal(200, defaultContext.Response.StatusCode);

        defaultContext.Response.Body.Seek(0, SeekOrigin.Begin);
        var body = await new StreamReader(defaultContext.Response.Body).ReadToEndAsync();

        Assert.NotNull(body);
        Assert.Equal(string.Empty, body);
    }

    [Theory]
    [InlineData("/api/status")]
    [InlineData("/API/STATUS")]
    [InlineData("/api/STATUS")]
    [InlineData("/API/status")]
    [Trait("TestCategory", "UnitTest")]
    public async void ApiKeyMiddleware_Should_Return_Ok_For_Status_Route_When_Anonymous(string path)
    {
        // Arrange
        var mockedConfigurationSection = new Mock<IConfigurationSection>();
        mockedConfigurationSection
            .Setup(_ => _.Value)
            .Returns(ApiKey);

        var mockedConfiguration = new Mock<IConfiguration>();
        mockedConfiguration
            .Setup(_ => _.GetSection(It.Is(ApiKeyMiddleware.ApiKeyConfigValue, StringComparer.Ordinal)))
            .Returns(mockedConfigurationSection.Object);

        var serviceCollection = new ServiceCollection();
        serviceCollection.AddScoped(_ => mockedConfiguration.Object);

        var defaultContext = new DefaultHttpContext
        {
            Response = { Body = new MemoryStream() },
            Request = { Path = path },
            RequestServices = serviceCollection.BuildServiceProvider()
        };

        var apiKeyMiddleware = new ApiKeyMiddleware(_ => Task.CompletedTask);

        // Act
        await apiKeyMiddleware.InvokeAsync(defaultContext);

        // Assert
        Assert.Equal(200, defaultContext.Response.StatusCode);

        defaultContext.Response.Body.Seek(0, SeekOrigin.Begin);
        var body = await new StreamReader(defaultContext.Response.Body).ReadToEndAsync();

        Assert.NotNull(body);
        Assert.Equal(string.Empty, body);
    }

    [Theory]
    [InlineData("/")]
    [InlineData("/api/stuff")]
    [InlineData("/api/stuff/with/long/route")]
    [InlineData("/not/api/route")]
    [InlineData(null)]
    [Trait("TestCategory", "UnitTest")]
    public async void ApiKeyMiddleware_Should_Return_Unauthorized_When_Api_Key_Header_Is_Missing_For_Non_Status_Routes(string path)
    {
        // Arrange
        var expectedBody = "{\"errorCode\":1000,\"message\":\"Client is unauthorized\"}";
        var mockedConfigurationSection = new Mock<IConfigurationSection>();
        mockedConfigurationSection
            .Setup(_ => _.Value)
            .Returns(ApiKey);

        var mockedConfiguration = new Mock<IConfiguration>();
        mockedConfiguration
            .Setup(_ => _.GetSection(It.Is(ApiKeyMiddleware.ApiKeyConfigValue, StringComparer.Ordinal)))
            .Returns(mockedConfigurationSection.Object);

        var serviceCollection = new ServiceCollection();
        serviceCollection.AddScoped(_ => mockedConfiguration.Object);

        var defaultContext = new DefaultHttpContext
        {
            Response = { Body = new MemoryStream() },
            Request = { Path = path },
            RequestServices = serviceCollection.BuildServiceProvider()
        };

        var apiKeyMiddleware = new ApiKeyMiddleware(_ => Task.CompletedTask);

        // Act
        await apiKeyMiddleware.InvokeAsync(defaultContext);

        // Assert
        Assert.Equal(401, defaultContext.Response.StatusCode);

        defaultContext.Response.Body.Seek(0, SeekOrigin.Begin);
        var body = await new StreamReader(defaultContext.Response.Body).ReadToEndAsync();

        Assert.NotNull(body);
        Assert.Equal(expectedBody, body);
    }
}
