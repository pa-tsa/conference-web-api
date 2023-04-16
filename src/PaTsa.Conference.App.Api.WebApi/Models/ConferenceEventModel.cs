using System;

namespace PaTsa.Conference.App.Api.WebApi.Models;

public class ConferenceEventModel
{
    public string? Description { get; set; }

    public DateTime EndDateTime { get; set; }

    public string? EventId { get; set; }

    public string? Id { get; set; }

    public string? Location { get; set; }

    public string? Name { get; set; }

    public DateTime StartDateTime { get; set; }

    public string? Type { get; set; }
}
