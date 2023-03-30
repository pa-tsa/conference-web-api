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
}
