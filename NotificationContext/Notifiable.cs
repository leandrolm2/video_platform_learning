using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_IN_C_SHARP.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }

        public void Add(Notification notification)
        {
            Notifications.Add(notification);
        }
        public void AddRange(IEnumerable<Notification> notification)
        {
            Notifications.AddRange(notification);
        }
    }
}
