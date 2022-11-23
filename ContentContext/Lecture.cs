using OOP_IN_C_SHARP.SharedContext;

namespace OOP_IN_C_SHARP.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
