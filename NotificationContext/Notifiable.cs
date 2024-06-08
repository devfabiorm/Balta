using System.Collections.Generic;

namespace Balta.NotificationContext
{
    public class Notifiable
    {
        public Notifiable()
        {
            Notifications = [];
        }

        public List<Notification> Notifications { get; set; }

        public void Add(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddRange(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }
    }
}