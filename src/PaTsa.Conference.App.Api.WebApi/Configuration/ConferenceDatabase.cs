// If the values are null, that means the app was miss configured
// If the app was miss configured, let the error bubble up

#pragma warning disable CS8618
namespace PaTsa.Conference.App.Api.WebApi.Configuration;

public class ConferenceDatabase
{
    public string DatabaseName { get; set; }
}
