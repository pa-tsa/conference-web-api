using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IList<ConferenceEventModel>>> Get(int pageNumber = 1, int pageSize = 25, CancellationToken cancellationToken = default)
    {
        var entities = await _conferenceEventsService.GetAsync(cancellationToken);

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
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<CreatedAtActionResult> Post(ConferenceEventModel conferenceEventModel, CancellationToken cancellationToken = default)
    {
        var conferenceEvent = conferenceEventModel.ToEntity();

        // TODO: Added to ToEntity method
        conferenceEvent.Id = null;

        await _conferenceEventsService.CreateAsync(conferenceEvent, cancellationToken);

        conferenceEventModel.Id = conferenceEvent.Id;

        return CreatedAtAction(nameof(Get), new { id = conferenceEvent.Id }, conferenceEventModel);
    }
}
