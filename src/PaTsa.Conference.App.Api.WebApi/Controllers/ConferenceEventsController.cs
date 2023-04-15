using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaTsa.Conference.App.Api.WebApi.Authorization;
using PaTsa.Conference.App.Api.WebApi.Entities;
using PaTsa.Conference.App.Api.WebApi.Models;
using PaTsa.Conference.App.Api.WebApi.Services;

namespace PaTsa.Conference.App.Api.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[Produces("application/json")]
public class ConferenceEventsController : ControllerBase
{
    private readonly IConferenceEventsService _conferenceEventsService;

    public ConferenceEventsController(IConferenceEventsService conferenceEventsService)
    {
        _conferenceEventsService = conferenceEventsService;
    }

    [HttpGet("{id:length(24)}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ConferenceEventModel))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ConferenceEventModel>> Get(string id, CancellationToken cancellationToken = default)
    {
        var conferenceEvent = await _conferenceEventsService.GetAsync(id, cancellationToken);

        if (conferenceEvent == null) return NotFound();

        return conferenceEvent.ToModel();
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IList<ConferenceEventModel>>> Get(
        string? types,
        int pageNumber = 1,
        int pageSize = 25,
        CancellationToken cancellationToken = default)
    {
        var entities = string.IsNullOrWhiteSpace(types)
            ? await _conferenceEventsService.GetAsync(cancellationToken)
            : await _conferenceEventsService.FilterAsync(types.Split(','), cancellationToken);

        //TODO: Evaluate performance and remediate as necessary
        return entities.Count == 0
            ? new List<ConferenceEventModel>(0)
            : entities
                .ToModels()
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
    }

    [HttpPost]
    [ApiKeyAuthorization]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<CreatedAtActionResult> Post(ConferenceEventModel conferenceEventModel, CancellationToken cancellationToken = default)
    {
        var conferenceEvent = conferenceEventModel.ToEntity(true);

        await _conferenceEventsService.CreateAsync(conferenceEvent, cancellationToken);

        conferenceEventModel.Id = conferenceEvent.Id;

        return CreatedAtAction(nameof(Get), new { id = conferenceEvent.Id }, conferenceEventModel);
    }

    [HttpPut("{id:length(24)}")]
    [ApiKeyAuthorization]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Put(string id, ConferenceEventModel updatedConferenceEventModel, CancellationToken cancellationToken = default)
    {
        var conferenceEvent = await _conferenceEventsService.GetAsync(id, cancellationToken);

        if (conferenceEvent == null) return NotFound();

        updatedConferenceEventModel.Id = conferenceEvent.Id;

        await _conferenceEventsService.UpdateAsync(updatedConferenceEventModel.ToEntity(), cancellationToken);

        return NoContent();
    }
}
