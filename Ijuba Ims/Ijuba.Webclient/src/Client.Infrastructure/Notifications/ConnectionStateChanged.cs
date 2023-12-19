using FSH.WebApi.Shared.Notifications;

namespace Ijuba.Webclient.Client.Infrastructure.Notifications;

public record ConnectionStateChanged(ConnectionState State, string? Message) : INotificationMessage;