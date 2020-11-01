using MyStore.Domain.Notifications;
using System.Collections.Generic;

namespace MyStore.Domain.Interfaces
{
    public interface INotificationContext
    {
        bool HasNotification();
        List<Notification> Notifications();
        void Handle(Notification notification);
    }
}
