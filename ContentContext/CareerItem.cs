using BaltaPOO.NotificationContext;
using System;

namespace BaltaPOO.ContentContext
{
    public class CareerItem : Content
    {
        public CareerItem(int order, string title, string url, string description, Course course) : base(title, url)
        {
            if (course == null)
                AddNotification(new Notification(nameof(course), "Curso não pode ser nulo"));

            Order = order;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}
