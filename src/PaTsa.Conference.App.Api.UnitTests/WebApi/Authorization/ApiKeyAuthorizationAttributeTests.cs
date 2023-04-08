using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using PaTsa.Conference.App.Api.UnitTests.Helpers;
using PaTsa.Conference.App.Api.WebApi.Authorization;
using PaTsa.Conference.App.Api.WebApi.Models;
using Xunit;

namespace PaTsa.Conference.App.Api.UnitTests.WebApi.Authorization;

[ExcludeFromCodeCoverage]
public class ApiKeyAuthorizationAttributeTests
{
    private const string ApiKey = "apikey";

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public void ApiKeyAuthorizationAttribute_Should_Return_Success_When_ApiKey_Is_Valid()
    {
        // Arrange
        var mockedConfigurationSection = new Mock<IConfigurationSection>();
        mockedConfigurationSection
            .Setup(_ => _.Value)
            .Returns(ApiKey);

        var mockedConfiguration = new Mock<IConfiguration>();
        mockedConfiguration
            .Setup(_ => _.GetSection(It.Is(ApiKeyAuthorizationAttribute.ApiKeyConfigValue, StringComparer.Ordinal)))
            .Returns(mockedConfigurationSection.Object);

        var serviceCollection = new ServiceCollection();
        serviceCollection.AddScoped(_ => mockedConfiguration.Object);

        var defaultContext = new DefaultHttpContext
        {
            Response = { Body = new MemoryStream() },
            RequestServices = serviceCollection.BuildServiceProvider()
        };

        defaultContext.Request.Headers.Add(ApiKeyAuthorizationAttribute.ApiHeaderKey, ApiKey);

        var actionContext = new ActionContext(defaultContext, new RouteData(), new ActionDescriptor());

        var authorizationFilterContext = new AuthorizationFilterContext(actionContext, new List<IFilterMetadata>());

        var apiKeyAuthorizationAttribute = new ApiKeyAuthorizationAttribute();

        // Act
        apiKeyAuthorizationAttribute.OnAuthorization(authorizationFilterContext);

        // Assert
        Assert.Null(authorizationFilterContext.Result);
    }

    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public void ApiKeyAuthorizationAttribute_Should_Return_Unauthorized_When_ApiKey_Header_Is_Missing()
    {
        // Arrange
        var mockedConfigurationSection = new Mock<IConfigurationSection>();
        mockedConfigurationSection
            .Setup(_ => _.Value)
            .Returns(ApiKey);

        var mockedConfiguration = new Mock<IConfiguration>();
        mockedConfiguration
            .Setup(_ => _.GetSection(It.Is(ApiKeyAuthorizationAttribute.ApiKeyConfigValue, StringComparer.Ordinal)))
            .Returns(mockedConfigurationSection.Object);

        var serviceCollection = new ServiceCollection();
        serviceCollection.AddScoped(_ => mockedConfiguration.Object);

        var defaultContext = new DefaultHttpContext
        {
            Response = { Body = new MemoryStream() },
            RequestServices = serviceCollection.BuildServiceProvider()
        };

        var actionContext = new ActionContext(defaultContext, new RouteData(), new ActionDescriptor());

        var authorizationFilterContext = new AuthorizationFilterContext(actionContext, new List<IFilterMetadata>());

        var apiKeyAuthorizationAttribute = new ApiKeyAuthorizationAttribute();

        // Act
        apiKeyAuthorizationAttribute.OnAuthorization(authorizationFilterContext);

        // Assert
        Assert.NotNull(authorizationFilterContext.Result);
        Assert.IsType<UnauthorizedObjectResult>(authorizationFilterContext.Result);

        var unauthorizedObjectResult = (UnauthorizedObjectResult)authorizationFilterContext.Result;

        Assert.IsType<ApiErrorModel>(unauthorizedObjectResult.Value);

        var apiErrorModel = (ApiErrorModel)unauthorizedObjectResult.Value;
        Assert.Equal(ApiErrorModel.Unauthorized, apiErrorModel, new ApiErrorModelEqualityComparer());
    }

    [Theory]
    [InlineData("")]
    [InlineData("12345")]
    [Trait("TestCategory", "UnitTest")]
    public void ApiKeyAuthorizationAttribute_Should_Return_Unauthorized_When_ApiKey_Is_Not_Valid(string apiKey)
    {
        // Arrange
        var mockedConfigurationSection = new Mock<IConfigurationSection>();
        mockedConfigurationSection
            .Setup(_ => _.Value)
            .Returns(ApiKey);

        var mockedConfiguration = new Mock<IConfiguration>();
        mockedConfiguration
            .Setup(_ => _.GetSection(It.Is(ApiKeyAuthorizationAttribute.ApiKeyConfigValue, StringComparer.Ordinal)))
            .Returns(mockedConfigurationSection.Object);

        var serviceCollection = new ServiceCollection();
        serviceCollection.AddScoped(_ => mockedConfiguration.Object);

        var defaultContext = new DefaultHttpContext
        {
            Response = { Body = new MemoryStream() },
            RequestServices = serviceCollection.BuildServiceProvider()
        };

        defaultContext.Request.Headers.Add(ApiKeyAuthorizationAttribute.ApiHeaderKey, apiKey);

        var actionContext = new ActionContext(defaultContext, new RouteData(), new ActionDescriptor());

        var authorizationFilterContext = new AuthorizationFilterContext(actionContext, new List<IFilterMetadata>());

        var apiKeyAuthorizationAttribute = new ApiKeyAuthorizationAttribute();

        // Act
        apiKeyAuthorizationAttribute.OnAuthorization(authorizationFilterContext);

        // Assert
        Assert.NotNull(authorizationFilterContext.Result);
        Assert.IsType<UnauthorizedObjectResult>(authorizationFilterContext.Result);

        var unauthorizedObjectResult = (UnauthorizedObjectResult)authorizationFilterContext.Result;

        Assert.IsType<ApiErrorModel>(unauthorizedObjectResult.Value);

        var apiErrorModel = (ApiErrorModel)unauthorizedObjectResult.Value;
        Assert.Equal(ApiErrorModel.Unauthorized, apiErrorModel, new ApiErrorModelEqualityComparer());
    }
}
