using FSH.WebApi.Shared.Notifications;

namespace Ijuba.Webclient.Client.Infrastructure.Notifications;

public interface INotificationPublisher
{
    Task PublishAsync(INotificationMessage notification);
}