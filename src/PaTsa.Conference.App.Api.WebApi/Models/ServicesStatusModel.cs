using System.Linq;

namespace PaTsa.Conference.App.Api.WebApi.Models;

public class ServicesStatusModel
{
    public bool ConferenceEventsServiceIsAlive { get; set; }

    public bool IsHealthy => EvaluateIsHealthy();

    private bool EvaluateIsHealthy()
    {
        var propertyInfos = GetType().GetProperties().Where(_ => _.CanWrite && _.PropertyType == typeof(bool));

        var isAliveList = propertyInfos.Select(propertyInfo => (bool)propertyInfo.GetValue(this)!).ToList();

        return isAliveList.All(isAlive => isAlive);
    }
}
