using FSH.WebApi.Shared.Notifications;

namespace ScreenDrafts.Web.Client.Infrastructure.Notifications;

public interface INotificationPublisher
{
    Task PublishAsync(INotificationMessage notification);
}