using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PaTsa.Conference.App.Api.WebApi.Models;

namespace PaTsa.Conference.App.Api.WebApi.Authorization;

public class ApiKeyAuthorizationAttribute : Attribute, IAuthorizationFilter
{
    public const string ApiHeaderKey = "X-API-Key";
    public const string ApiKeyConfigValue = "ApiKey";

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var configuration = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();

        var apiKey = configuration.GetValue<string>(ApiKeyConfigValue);

        if (!context.HttpContext.Request.Headers.TryGetValue(ApiHeaderKey, out var sentApiKey) ||
            string.IsNullOrWhiteSpace(sentApiKey) ||
            sentApiKey != apiKey)
        {
            context.Result = new UnauthorizedObjectResult(ApiErrorModel.Unauthorized);
        }
    }
}
