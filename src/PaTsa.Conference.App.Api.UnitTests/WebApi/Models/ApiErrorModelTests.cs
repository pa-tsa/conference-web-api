using System.Diagnostics.CodeAnalysis;
using PaTsa.Conference.App.Api.WebApi.Models;
using Xunit;

namespace PaTsa.Conference.App.Api.UnitTests.WebApi.Models;

[ExcludeFromCodeCoverage]
public class ApiErrorModelTests
{
    [Fact]
    [Trait("TestCategory", "UnitTest")]
    public void Unauthorized_Should_Return_ApiErrorResponse_For_Unauthorized()
    {
        // Arrange
        // Act
        var apiErrorModel = ApiErrorModel.Unauthorized;

        // Assert
        Assert.Equal((int)ErrorCodes.Unauthorized, apiErrorModel.ErrorCode);
        Assert.Equal("Client is unauthorized", apiErrorModel.Message);
    }
}
