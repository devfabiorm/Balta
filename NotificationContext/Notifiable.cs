using System.Collections.Generic;
using System.Linq;

namespace Balta.NotificationContext
{
    public class Notifiable
    {
        public Notifiable()
        {
            Notifications = [];
        }

        public List<Notification> Notifications { get; set; }
        public bool IsInvalid => Notifications.Count > 0;

        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }
    }
}