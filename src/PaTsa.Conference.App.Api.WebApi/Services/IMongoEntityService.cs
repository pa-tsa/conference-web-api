using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PaTsa.Conference.App.Api.WebApi.Services;

public interface IMongoEntityService<T>
{
    string CollectionName { get; }

    Task CreateAsync(T entity, CancellationToken cancellationToken = default);

    Task<bool> ExistsAsync(string id, CancellationToken cancellationToken = default);

    Task<List<T>> GetAsync(CancellationToken cancellationToken = default);

    Task<List<T>> GetAsync(IEnumerable<string> ids, CancellationToken cancellationToken = default);

    Task<T?> GetAsync(string id, CancellationToken cancellationToken = default);

    Task RemoveAsync(T entity, CancellationToken cancellationToken = default);

    Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
}
