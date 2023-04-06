using System;

namespace PaTsa.Conference.App.Api.Cli;

public class EnvironmentVariableProvider
{
    private string GetSecret(string secretName)
    {
        var secret = Environment.GetEnvironmentVariable(secretName);

        return string.IsNullOrEmpty(secret)
            ? throw new Exception($"{secretName} environment variable is not set.")
            : secret;
    }
}
