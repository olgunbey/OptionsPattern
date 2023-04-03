namespace Options_Pattern
{
    public class Info
    {
        
    }
    public class MailInfo
    {
        public int Port { get; set; }
        public string? Host { get; set; }
        public EmailInfo EmailInfo { get; set; }
    }
    public class EmailInfo
    {
        public string? Gmail { get; set; }
        public string? Password { get; set; }
    }
}
