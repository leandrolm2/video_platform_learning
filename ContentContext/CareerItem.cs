namespace OOP_IN_C_SHARP.ContentContext
{
    public class CareerItem : Base
    {

        public CareerItem(int order, string title, string description, Course course)
        {
            if (course == null) throw new Exception("You cannot send a null value to course");
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}
