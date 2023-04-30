using FSH.WebApi.Shared.Notifications;

namespace ScreenDrafts.Web.Client.Infrastructure.Notifications;

public record ConnectionStateChanged(ConnectionState State, string? Message) : INotificationMessage;