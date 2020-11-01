using MyStore.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MyStore.Domain.Notifications
{
    public class NotificationContext : INotificationContext
    {
        private List<Notification> _notifications;

        public NotificationContext()
        {
            _notifications = new List<Notification>();
        }

        public void Handle(Notification notification)
        {
            _notifications.Add(notification);
        }

        public bool HasNotification()
        {
            return _notifications.Any();
        }

        public List<Notification> Notifications()
        {
            return _notifications;
        }
    }
}
