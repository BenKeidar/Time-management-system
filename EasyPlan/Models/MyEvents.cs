using System;

namespace Win1.Models
{
    public class MyEvents
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Category { get; set; } = "Work";
        public DateTime Start {get; set; } 
        public DateTime End {get; set; } 

        public MyEvents(string id, string text, string description, string category, DateTime start, DateTime end)
        {
            Id = id;
            Text = text;
            Description = description;
            Category = category;
            Start = start;
            End = end;
        }
    }
}