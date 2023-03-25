using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PaTsa.Conference.App.Api.WebApi.Models;

namespace PaTsa.Conference.App.Api.WebApi.Middleware;

public class ApiKeyMiddleware
{
    public const string ApiHeaderKey = "X-API-Key";
    public const string ApiKeyConfigValue = "ApiKey";

    private readonly RequestDelegate _requestDelegate;

    public ApiKeyMiddleware(RequestDelegate requestDelegate)
    {
        _requestDelegate = requestDelegate;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if (context.Request.Path.HasValue &&
            context.Request.Path.Value.Equals("/api/status", StringComparison.InvariantCultureIgnoreCase))
        {
            await _requestDelegate(context);
            return;
        }

        var configuration = context.RequestServices.GetRequiredService<IConfiguration>();

        var apiKey = configuration.GetValue<string>(ApiKeyConfigValue);

        if (!context.Request.Headers.TryGetValue(ApiHeaderKey, out var sentApiKey) ||
            string.IsNullOrWhiteSpace(sentApiKey) ||
            sentApiKey != apiKey)
        {
            SetUnauthorizedResponse(context.Response);
            return;
        }

        await _requestDelegate(context);
    }

    private static async void SetUnauthorizedResponse(HttpResponse httpResponse)
    {
        httpResponse.StatusCode = 401;
        await httpResponse.WriteAsJsonAsync(ApiErrorModel.Unauthorized);
    }
}
