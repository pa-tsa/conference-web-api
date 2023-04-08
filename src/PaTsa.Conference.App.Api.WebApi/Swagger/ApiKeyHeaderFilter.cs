using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using PaTsa.Conference.App.Api.WebApi.Authorization;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace PaTsa.Conference.App.Api.WebApi.Swagger;

// This should be excluded from code coverage
// It is only used during development and local testing
[ExcludeFromCodeCoverage]
public class ApiKeyHeaderFilter : IOperationFilter
{
    public IConfiguration Configuration { get; }

    public ApiKeyHeaderFilter(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        if (string.Equals(context.ApiDescription.HttpMethod, "get", StringComparison.InvariantCultureIgnoreCase)) return;
        
        var apiKey = Configuration.GetValue<string>(ApiKeyAuthorizationAttribute.ApiKeyConfigValue);

        operation.Parameters ??= new List<OpenApiParameter>();

        operation.Parameters.Add(new OpenApiParameter
        {
            In = ParameterLocation.Header,
            Example = new OpenApiString(apiKey),
            Name = ApiKeyAuthorizationAttribute.ApiHeaderKey,
            Required = true
        });
    }
}
