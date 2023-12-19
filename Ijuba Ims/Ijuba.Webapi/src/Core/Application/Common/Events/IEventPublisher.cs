using Ijuba.Webapi.Shared.Events;

namespace Ijuba.Webapi.Application.Common.Events;

public interface IEventPublisher : ITransientService
{
    Task PublishAsync(IEvent @event);
}