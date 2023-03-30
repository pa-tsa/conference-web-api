using PaTsa.Conference.App.Api.WebApi.Entities;

namespace PaTsa.Conference.App.Api.WebApi.Services;

public interface IConferenceEventsService : IMongoEntityService<ConferenceEvent>, IPingableService { }
