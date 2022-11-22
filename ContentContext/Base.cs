using OOP_IN_C_SHARP.NotificationContext;

namespace OOP_IN_C_SHARP.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
