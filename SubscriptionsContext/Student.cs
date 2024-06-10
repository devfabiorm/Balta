using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = [];
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "O aluno já possui assinature ativa."));
                return;
            }

            Subscriptions.Add(subscription);
        }
    }
}