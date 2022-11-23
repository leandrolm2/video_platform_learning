using OOP_IN_C_SHARP.NotificationContext;

namespace OOP_IN_C_SHARP.SharedContext
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
