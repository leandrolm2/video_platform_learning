﻿namespace OOP_IN_C_SHARP.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }

        //Expression Body
        public int TotalCourses => Items.Count;

    }

}
