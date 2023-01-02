namespace LibTelegram
{
    public class TelegramResult
    {
        public bool ok { get; set; }
        public Result result { get; set; }

        public string error { get; set; }
    }
    
    public class Chat
    {
        public string id { get; set; }
        public string title { get; set; }
        public string username { get; set; }
        public string type { get; set; }
    }

    public class Result
    {
        public string message_id { get; set; }
        public Chat chat { get; set; }
        public string date { get; set; }
        public string text { get; set; }
    }
}
