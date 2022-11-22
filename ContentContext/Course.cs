using OOP_IN_C_SHARP.ContentContext.Enums;

namespace OOP_IN_C_SHARP.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url) : base(title, url)
        {
            Modules = new List<Module>();
        }
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level  { get; set; }
    }

}
