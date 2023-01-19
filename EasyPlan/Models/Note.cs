﻿namespace Win1.Models
{
    public class Note
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Note(string id, string title, string text)
        {
            Id = id;
            Title = title;
            Text = text;
        }
    }
}