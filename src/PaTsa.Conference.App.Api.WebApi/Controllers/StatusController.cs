using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PaTsa.Conference.App.Api.WebApi.Models;
using PaTsa.Conference.App.Api.WebApi.Services;

namespace PaTsa.Conference.App.Api.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[Produces("application/json")]
public class StatusController : ControllerBase
{
    private readonly ILogger<StatusController> _logger;
    private readonly List<IPingableService> _pingableServices = [];

    public StatusController(IEnumerable<IPingableService> pingableServices, ILogger<StatusController> logger)
    {
        _logger = logger;
        _pingableServices.AddRange(pingableServices);
    }

    [AllowAnonymous]
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<ServicesStatusModel>> Get(CancellationToken cancellationToken = default)
    {
        var servicePingResultsList = new List<Tuple<string, bool>>();

        foreach (var pingableService in _pingableServices)
        {
            bool isAlive;
            try
            {
                isAlive = await pingableService.PingAsync(cancellationToken);
            }
            catch (Exception exception)
            {
                isAlive = false;
                _logger.LogError(exception, "Unknown failure while attempting to check status");
            }

            servicePingResultsList.Add(new Tuple<string, bool>(pingableService.ServiceName, isAlive));
        }

        var servicesStatusModelType = typeof(ServicesStatusModel);
        var servicesStatusModel = new ServicesStatusModel();

        foreach (var tuple in servicePingResultsList)
        {
            var propertyInfo = servicesStatusModelType.GetProperty($"{tuple.Item1}ServiceIsAlive");

            if (propertyInfo == null) continue;

            propertyInfo.SetValue(servicesStatusModel, tuple.Item2);
        }

        return servicesStatusModel.IsHealthy
            ? Ok(servicesStatusModel)
            : StatusCode(StatusCodes.Status500InternalServerError, servicesStatusModel);
    }
}
