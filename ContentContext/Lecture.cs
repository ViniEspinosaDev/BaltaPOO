using BaltaPOO.ContentContext.Enums;

namespace BaltaPOO.ContentContext
{
    public class Lecture : Content
    {
        public Lecture(int order, string title, int durationInMinutes, EContentLevel level, string url) : base(title, url)
        {
            Order = order;
            Title = title;
            DurationInMinutes = durationInMinutes;
            Level = level;
        }

        public int Order { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
