using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_IN_C_SHARP.NotificationContext
{
    public sealed class Notification
    {
        public Notification()
        {

        }

        public Notification(int property, string message)
        {
            Property = property;
            Message = message;
        }

        public int Property { get; set; }
        public string Message { get; set; }
    }
}
