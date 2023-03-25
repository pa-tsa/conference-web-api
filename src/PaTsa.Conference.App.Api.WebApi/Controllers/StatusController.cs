﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System;
using PaTsa.Conference.App.Api.WebApi.Models;
using PaTsa.Conference.App.Api.WebApi.Services;

namespace PaTsa.Conference.App.Api.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class StatusController : ControllerBase
    {
        private readonly List<IPingableService> _pingableServices = new();

        public StatusController(IEnumerable<IPingableService> pingableServices)
        {
            _pingableServices.AddRange(pingableServices);
        }

        [AllowAnonymous]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ServicesStatusModel>> Get(CancellationToken cancellationToken = default)
        {
            var concurrentBag = new ConcurrentBag<Tuple<string, bool>>();

            await Parallel.ForEachAsync(_pingableServices, cancellationToken, async (pingableService, pingCancellationToken) =>
            {
                bool isAlive;
                try
                {
                    isAlive = await pingableService.PingAsync(pingCancellationToken);
                }
                catch (Exception)
                {
                    isAlive = false;
                }

                concurrentBag.Add(new Tuple<string, bool>(pingableService.ServiceName, isAlive));
            });

            var servicesStatusModelType = typeof(ServicesStatusModel);
            var servicesStatusModel = new ServicesStatusModel();

            foreach (var tuple in concurrentBag)
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
}
