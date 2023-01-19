using System;

namespace Win1.Models
{
    public class MyTask
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public int Done { get; set; }
        public string Deadline { get; set; }

        public MyTask(string id, string text, int done, DateTime deadline)
        {
            Id = id;
            Text = text;
            Done = done;
            Deadline = deadline.ToShortDateString();
        }
    }
}