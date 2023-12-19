using Ijuba.Webapi.Shared.Events;

namespace Ijuba.Webapi.Domain.Common.Contracts;

public abstract class DomainEvent : IEvent
{
    public DateTime TriggeredOn { get; protected set; } = DateTime.UtcNow;
}