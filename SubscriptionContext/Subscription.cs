using OOP_IN_C_SHARP.SharedContext;

namespace OOP_IN_C_SHARP.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive => EndDate <= DateTime.Now;
    }
}
