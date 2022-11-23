using OOP_IN_C_SHARP.NotificationContext;
using OOP_IN_C_SHARP.SharedContext;
using System.Globalization;


namespace OOP_IN_C_SHARP.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscription = new List<Subscription>();
        }
        public StringInfo Name { get; set; }
        public StringInfo Email { get; set; }
        public User User { get; set; }

        public IList<Subscription> Subscription { get; set; }
        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "the student is already enrolled"));
                return;
            }

            Subscription.Add(subscription);
        }
        public bool IsPremium => Subscription.Any(x => !x.IsActive);
        
    }
}
