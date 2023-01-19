namespace Win1.Models
{
    public class MyNotification
    {
        public string Id { get; set; }
        public string Ntime { get; set; }
        public string Nmessage { get; set; }
        public MyNotification(string id, string timeToNotify, string messageToNotify)
        {
            Id = id;
            Ntime = timeToNotify;
            Nmessage = messageToNotify;
        }
    }
}